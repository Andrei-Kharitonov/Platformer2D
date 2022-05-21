using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    private bool isWin = false;

    [SerializeField] private Text WinText;

    private void Update()
    {
        NextLevel();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WinText.text = "YOU WIN!\n \nPress N to go on next level";
            isWin = true;
            Time.timeScale = 0;
        }
    }

    private void NextLevel()
    {
        if (Input.GetKeyDown(KeyCode.N) && isWin)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
