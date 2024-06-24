using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;


    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
      
    } 
    public void loadLevel()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
   
  
    

}
