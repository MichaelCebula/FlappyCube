using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameOver = false;
    public float restartDelay = 4f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {

        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }

    public void WinGame()
    {
        Debug.Log("Level complete");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
