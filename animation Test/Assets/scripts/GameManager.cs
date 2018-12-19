using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
public void EndGame()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene("GameOver");
        }
           
    }
	
}
