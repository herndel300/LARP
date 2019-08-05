using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{
    public Animator enemyAnimator;
    Animator playerAnimator;
    Rigidbody2D enemyRb;
    public GameObject player;
    public GameObject enemy;
    public GameObject controller;
    bool isTouchingPlayer = false;
    bool isDead;
    bool facingRight;
    bool facingLeft;
    
    //required variables for AI tracking
    public float speed = 10f;
    private Transform target;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        controller = GameObject.FindGameObjectWithTag("Controller");
        enemyAnimator = GetComponent<Animator>();
        playerAnimator = player.GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        timer = Time.time + 3;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Enemy is touching player");
        }
    }
    //Handles collisions with player
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isTouchingPlayer = true;

            //checks if both player and enemy colliders are touching and player is attacking
            if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsTag("attack") && isDead == false)
            {
                isDead = true;
                enemyRb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                enemyAnimator.Play("Death"); //plays enemy death animation
                Destroy(enemy, 0.5f); //Destorys enemy gameobject 3 seconds after the death animation is finished
                controller.GetComponent<LevelBehavior>().killCount = controller.GetComponent<LevelBehavior>().killCount + 1;
                
            }

            //checks if both player and enemy colliders are touching and enemy is attacking
            if (enemyAnimator.GetCurrentAnimatorStateInfo(0).IsTag("enemyAttack"))
            {
                player.GetComponent<PlayerCharacteristics>().health = player.GetComponent<PlayerCharacteristics>().health - 1;
                Debug.Log(player.GetComponent<PlayerCharacteristics>().health);
            }
        }

        //enemy is hit by a player projectile
        if (collision.gameObject.tag == "Projectile" && isDead == false)
        {
            Debug.Log("enemy was hit by spell");
            Destroy(collision.gameObject); //prevents the projectile from passing through enemies
            isDead = true;
            enemyRb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation; 
            enemyAnimator.Play("Death"); //plays enemy death animation
            Destroy(enemy, 0.5f); //Destroys enemy gameobject 3 seconds after the death animation is finished
            controller.GetComponent<LevelBehavior>().killCount = controller.GetComponent<LevelBehavior>().killCount + 1;
            
        }

        //handles door openings so enemy can break down doors
        /*/Can only occur after 3 seconds
        if (timer < Time.time && collision.gameObject.tag == "Door")
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == false)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorOpenLeft");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = true;
            }
        }

        if (timer < Time.time && collision.gameObject.tag == "DoorSideWays")
        {
            if (collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen == false)
            {
                collision.gameObject.GetComponent<DoorBehavior>().doorAnimator.Play("DoorOpenSideways");
                collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
                collision.gameObject.GetComponent<DoorBehavior>().doorIsOpen = true;
            }
        }*/
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Enemy is no longer touching player");
        isTouchingPlayer = false;
    }

    //Updates enemy position based on player position (pathfinding)
    void Update()
    {
        player.GetComponent<PlayerCharacteristics>().HandleHealth();

        if (isDead == false) //prevents enemy from continuously walking after death
        {
            //checks if enemy is within attack range of the player, then checks the enemy's direction to play the correct animation
            if (isTouchingPlayer == true)
            {
                if (facingLeft == true)
                {
                    enemyAnimator.Play("AttackLeft");
                }

                if (facingRight == true)
                {
                    enemyAnimator.Play("AttackRight");
                }
            }

            if (Vector2.Distance(transform.position, target.position) > 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }

            //x position value is currently increasing
            //enemy is currently walking right
            if (target.position.x > transform.position.x && isTouchingPlayer == false)
            {
                facingLeft = false;
                facingRight = true;
                enemyAnimator.Play("WalkingRight");
                //Debug.Log("enemy is moving right");
            }

            //x position value is currently decreasing
            //enemy is currently walking left
            if (target.position.x < transform.position.x && isTouchingPlayer == false) //x value is currently decreasing
            {
                facingLeft = true;
                facingRight = false;
                enemyAnimator.Play("WalkingLeft");
                //Debug.Log("enemy is moving left");
            }

            /*if(enemyAnimator.GetCurrentAnimatorStateInfo(0).IsTag("enemyAttack"))
            {
                //Debug.Log("enemy is attacking");
            }*/
        }
    }
}
        


