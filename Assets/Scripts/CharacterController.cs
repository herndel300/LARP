using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour {

    public Animator animator;
    public float characterSpeed = 10.0f;
    private bool isMoving;
    private bool isAttacking;

    Rigidbody2D playerRb;
    public GameObject spellAttackRight;
    public GameObject spellAttackLeft;
    public GameObject spellAttackUp;
    public GameObject spellAttackDown;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public Text playerLocationText;
    public bool pauseMenuIsOpen = false;
    Vector2 spellPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    private Transform playerPosition;
    public GameObject[] spawnPoints;
    public AudioSource audioSource;
    public AudioClip swordClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = swordClip;
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //Handles door opening event
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door" && Input.GetKeyDown(KeyCode.Space))
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == false)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorOpenLeft");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = true;
            }
        }

        if (collision.gameObject.tag == "DoorSideWays" && Input.GetKeyDown(KeyCode.Space))
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == false)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorOpenSideways");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = true;
            }
        }
      
    }

    //Handles door closing event
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door" && Input.GetKeyDown(KeyCode.Space))
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == true)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorCloseLeft");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = false;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = false;
            }
        }

        if (collision.gameObject.tag == "DoorSideWays" && Input.GetKeyDown(KeyCode.Space))
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == true)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorCloseSideways");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = false;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = false;
            }
        }
    }

    //Handles spell prefabs and direction of velocity
    private void SpellAttack()
    {
        spellPos = transform.position;

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("IdleRight") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingRight"))
        {
            spellPos += new Vector2(+1f, -0.43f);
            Instantiate(spellAttackRight, spellPos, Quaternion.identity);

            //Destroys projectile 1 second after being cast
            //Prevents projectiles from crossing both ends of the map
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                Destroy(o, 1f);
            }
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("IdleLeft") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingLeft"))
        {
            spellPos += new Vector2(-1f, -0.43f);
            Instantiate(spellAttackLeft, spellPos, Quaternion.identity);

            //Destroys projectile 1 second after being cast
            //Prevents projectiles from crossing both ends of the map
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                Destroy(o, 1f);
            }
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleUp") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingUp"))
        {
            spellPos += new Vector2(0f, +1f);
            Instantiate(spellAttackUp, spellPos, Quaternion.identity);

            //Destroys projectile 1 second after being cast
            //Prevents projectiles from crossing both ends of the map
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                Destroy(o, 1f);
            }
            
        }
    
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleDown") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingDown"))
        {
            spellPos += new Vector2(0f, -1f);
            Instantiate(spellAttackDown, spellPos, Quaternion.identity);

            //Destroys projectile 1 second after being cast
            //Prevents projectiles from crossing both ends of the map
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                Destroy(o, 1f);
            }
        }
    }

    //CHARACTER MOVEMENT INPUTS
    private void HandleInput()
    {
        //Pause Menu Behavior
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //opens pause menu
            //checks if game over menu is open so the player cannot open both
            if (pauseMenuIsOpen == false && gameOverMenu.activeSelf == false)
            {
                Time.timeScale = 0; //freezes the scene
                pauseMenu.SetActive(true);
                pauseMenuIsOpen = true;
            }

            //closes pause menu
            else if(pauseMenuIsOpen == true && gameOverMenu.activeSelf == false)
            {
                Time.timeScale = 1; //resumes the scene
                pauseMenu.SetActive(false);
                pauseMenuIsOpen = false;
            }
        }

        if (isAttacking == false)
        {  
            if (Input.GetKey(KeyCode.W))
            {
                animator.Play("WalkingUp");
            }

            else if (Input.GetKey(KeyCode.A))
            {
                animator.Play("WalkingLeft");
            }

            else if (Input.GetKey(KeyCode.S))
            {
                animator.Play("WalkingDown");
            }

            else if (Input.GetKey(KeyCode.D))
            {
                animator.Play("WalkingRight");
            }
        }
    }

    //CHARACTER ATTACK INPUTS
    private void HandleAttackInput()
    {
        if (isMoving == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleRight") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingRight")))
            {
                audioSource.Play();
                animator.Play("SwordAttackRight");
            }

            else if (Input.GetKeyDown(KeyCode.Mouse0) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleLeft") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingLeft")))
            {
                audioSource.Play();
                animator.Play("SwordAttackLeft");
            }

            else if (Input.GetKeyDown(KeyCode.Mouse0) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleUp") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingUp")))
            {
                audioSource.Play();
                animator.Play("SwordAttackUp");
            }

            else if (Input.GetKeyDown(KeyCode.Mouse0) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleDown") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingDown")))
            {
                audioSource.Play();
                animator.Play("SwordAttackDown");
            }

            if (Input.GetKeyDown(KeyCode.Mouse1) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleRight") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingRight")))
            {
                animator.Play("SpellAttackRight");
                SpellAttack();
            }

            else if (Input.GetKeyDown(KeyCode.Mouse1) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleLeft") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingLeft")))
            {
                animator.Play("SpellAttackLeft");
                SpellAttack();
            }

            else if (Input.GetKeyDown(KeyCode.Mouse1) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleUp") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingUp")))
            {
                animator.Play("SpellAttackUp");
                SpellAttack();
            }

            else if (Input.GetKeyDown(KeyCode.Mouse1) && (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleDown") || animator.GetCurrentAnimatorStateInfo(0).IsName("WalkingDown")))
            {
                animator.Play("SpellAttackDown");
                SpellAttack();
            }
        }
    }

    private void HandleSpawnPoints()
    {
        //Handles initial room's spawn points
        if(playerPosition.transform.position.x < 837 && playerPosition.transform.position.x > 804
            && playerPosition.transform.position.y < 514 && playerPosition.transform.position.y > 490)
        {
            Debug.Log("Player is in first area");
            playerLocationText.text = "Main Hall";
            spawnPoints[0].SetActive(true);
            spawnPoints[1].SetActive(true);
    
        }

        else
        {
            spawnPoints[0].SetActive(false);
            spawnPoints[1].SetActive(false);
        }

        //Handles top room's spawn points
        if (playerPosition.transform.position.x < 830 && playerPosition.transform.position.x > 811
            && playerPosition.transform.position.y < 522 && playerPosition.transform.position.y > 515)
        {
            playerLocationText.text = "Top Room";
            Debug.Log("Player is in the top room");
            spawnPoints[2].SetActive(true);
        }

        else
        {
            spawnPoints[2].SetActive(false);
        }

        //Handles bottom room's spawn points
        if (playerPosition.transform.position.x < 830 && playerPosition.transform.position.x > 811
            && playerPosition.transform.position.y < 488 && playerPosition.transform.position.y > 481)
        {
            playerLocationText.text = "Bottom Room";
            Debug.Log("Player is in the bottom room");
            spawnPoints[3].SetActive(true);
        }

        else
        {
            spawnPoints[3].SetActive(false);
        }

        //Handles left room's spawn points
        if (playerPosition.transform.position.x < 803 && playerPosition.transform.position.x > 785
            && playerPosition.transform.position.y < 505 && playerPosition.transform.position.y > 498)
        {
            playerLocationText.text = "Left Room";
            Debug.Log("Player is in the left room");
            spawnPoints[4].SetActive(true);
        }

        else
        {
            spawnPoints[4].SetActive(false);
        }

        //Handles right room's spawn points
        if (playerPosition.transform.position.x < 855 && playerPosition.transform.position.x > 837
            && playerPosition.transform.position.y < 505 && playerPosition.transform.position.y > 498)
        {
            playerLocationText.text = "Right Room";
            Debug.Log("Player is in the right room");
            spawnPoints[5].SetActive(true);
        }

        else
        {
            spawnPoints[5].SetActive(false);
        }

        //Handles bottom left halls's spawn points
        if (playerPosition.transform.position.x < 811 && playerPosition.transform.position.x > 789
            && playerPosition.transform.position.y < 496 && playerPosition.transform.position.y > 481)
        {
            playerLocationText.text = "Bottom Hall (Left)";
            Debug.Log("Player is in the bottom left hall");
            spawnPoints[6].SetActive(true);
        }

        else
        {
            spawnPoints[6].SetActive(false);
        }

        //Handles bottom right halls's spawn points
        if (playerPosition.transform.position.x < 852 && playerPosition.transform.position.x > 830
            && playerPosition.transform.position.y < 496 && playerPosition.transform.position.y > 481)
        {
            playerLocationText.text = "Bottom Hall (Right)";
            Debug.Log("Player is in the bottom right hall");
            spawnPoints[7].SetActive(true);
        }

        else
        {
            spawnPoints[7].SetActive(false);
        }

        //Handles top left halls's spawn points
        if (playerPosition.transform.position.x < 811 && playerPosition.transform.position.x > 789
            && playerPosition.transform.position.y < 523 && playerPosition.transform.position.y > 506)
        {
            playerLocationText.text = "Top Hall (Left)";
            Debug.Log("Player is in the top left hall");
            spawnPoints[8].SetActive(true);
        }

        else
        {
            spawnPoints[8].SetActive(false);
        }

        //Handles top right halls's spawn points
        if (playerPosition.transform.position.x < 852 && playerPosition.transform.position.x > 830
            && playerPosition.transform.position.y < 523 && playerPosition.transform.position.y > 506)
        {
            playerLocationText.text = "Top Hall (Right)";
            Debug.Log("Player is in the top right hall");
            spawnPoints[9].SetActive(true);
        }

        else
        {
            spawnPoints[9].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += movement * characterSpeed * Time.deltaTime;

        HandleInput();
        HandleAttackInput();
        HandleSpawnPoints();
    }
}

