using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                SetPause();
            }
        }
    }

    public void SetPause()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("cherriesCount", 0);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
