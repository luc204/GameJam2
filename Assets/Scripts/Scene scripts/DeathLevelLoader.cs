using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathLevelLoader : MonoBehaviour
{
    private bool player1present = false;
    private bool player2present = false;

    public void LoadDeathLevel()
    {
        SceneManager.LoadScene("DeathLevel");  
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
            LoadDeathLevel();
        }
        else
        {
            Debug.Log("No more levels"); //will just make a finale scene that is the end game scene 
        }
    }
}
