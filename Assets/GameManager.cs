using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject cam;
    public GameObject gameOverUI;

    void Start()
    {
        FindObjectOfType<KillPlayer>().OnPlayerDeath += EndGame;
    }
    void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            print("GameOver");
            Destroy(cam);
            gameOverUI.SetActive(true);



        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameHasEnded)
        {
            Restart();
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
