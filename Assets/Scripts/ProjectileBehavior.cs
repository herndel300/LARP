using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float velX = 5f;
    public float velY = 0f;
    Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Door" || collision.gameObject.tag == "Wall" || collision.gameObject.tag == "DoorSideWays" || collision.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //adjusts velocity of projectile
        rb.velocity = new Vector2(velX, velY);
    }
}
