using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public int iLoadLevel;
    public string sLoadLevel;

    public bool useIntToLoadLevel = false;

    public GameManager gameManager;

    public void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        gameManager.WinGame();

        if (collisionGameObject.tag == "Player")
        {
            LoadScene();
        }

        void LoadScene()
        {

            if (useIntToLoadLevel)
            {
                SceneManager.LoadScene(iLoadLevel);
            }
            else
            {
                SceneManager.LoadScene(sLoadLevel);
            }
        }
    }
}
