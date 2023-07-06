using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool Gamehasended = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("LEvel !");
        completeLevelUI.SetActive(true);
    }
    // Start is called before the first frame update
    public void EndGame()
    {

        if (Gamehasended == false)
        {
            Gamehasended = true;
            Debug.Log("EndGame");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("Level One");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}