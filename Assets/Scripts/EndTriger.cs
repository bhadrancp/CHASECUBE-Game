using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.completeLevel();
        gameManager.Invoke("loadLevel", 1f);
    }


}
