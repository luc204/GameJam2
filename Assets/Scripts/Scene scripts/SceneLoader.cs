using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    private bool player1present = false;
    private bool player2present = false;

    public void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
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
            NextLevel();
        }
        else
        {
            Debug.Log("No more levels"); //will just make a finale scene that is the end game scene 
        }
    }
}
