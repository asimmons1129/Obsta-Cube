using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LoadNextLevel()
    {
        Debug.Log("LEVEL COMPLETED");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
