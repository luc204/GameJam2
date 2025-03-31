using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float Speed = 2f;
    public float JumpForce = 1f;
    public bool isGrounded;
    // the basic floats for player movement
    // and the bool to check if the player is touching the ground

    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.tag = "Player1";
        // this is so that im declaring the rigidbody and the tag of the player at the start
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
        // this is all the basic code for the movement
        // its the simplest version I could find that works for also checking if the player is grounded
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Object"))
        {
            isGrounded = true;
        }
        //the code to check if the player is grounded
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Object"))
        {
            isGrounded = false;
        }
        //the code to check if the player is not grounded
    }
}