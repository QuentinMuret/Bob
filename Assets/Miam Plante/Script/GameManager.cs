using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject cam;
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject levelEnd;

    void Start()
    {
        FindObjectOfType<KillPlayer>().OnPlayerDeath += LoseGame;
        FindObjectOfType<EnterZone>().OnPlayerWin += WinGame;
        BoxCollider2D endCollider = levelEnd.GetComponent<BoxCollider2D>();
    }
    void LoseGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Destroy(cam);
            gameOverUI.SetActive(true);

        }
        
    }

    void WinGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            gameWinUI.SetActive(true);
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
