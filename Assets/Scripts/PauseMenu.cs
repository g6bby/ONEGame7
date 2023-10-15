using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    private AudioListener audioListener;

    void Start()
    {
        audioListener = Camera.main.GetComponent<AudioListener>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        AudioListener.pause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        AudioListener.pause = true;
    }

    public void RestartTheGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
