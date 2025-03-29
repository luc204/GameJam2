using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float openheight = 5f;
    public float openspeed = 2f;
    public bool isOpening = false;
    public Vector2 openposition;
    public Vector2 closeposition;
    // these are all the functions that are needed to open the door,
    // the bool to keep the door closed unless the players are present
    // and the Vector2 positions to have restraints for how open it can be 

    private bool player1present = false;
    private bool player2present = false;

    void Start()
    {
        closeposition = transform.position;
        openposition = closeposition + Vector2.up * openheight;
    }

   
    void FixedUpdate()
    {
        if (isOpening)
        { 
           transform.position = Vector2.MoveTowards(transform.position, openposition, openspeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, closeposition, openspeed * Time.deltaTime);
        }
       
        //this is the code that opens the door, but when the is opening bool is false it will automatically close the door
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            player1present = true;
        }
        else if (other.CompareTag("Player2"))
        {
            player2present = true;
        }
        if (player1present && player2present)
        {
            isOpening = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            player1present = false;
        }
        else if (other.CompareTag("Player2"))
        {
            player2present = false;
        }
        if (!player1present || !player2present)
        {
            isOpening = false;
        }

    }



}
