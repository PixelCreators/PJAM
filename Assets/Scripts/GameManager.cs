using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const string GameOverSceneName = "GameOver";
    public static GameManager Instance;

    private bool _gameOver = false;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void GameOver()
    {
        _gameOver = true;
        SceneManager.LoadScene(GameOverSceneName);
    }
}
