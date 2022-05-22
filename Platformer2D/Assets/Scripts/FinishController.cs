using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    private bool isWin = false;

    [SerializeField] private GameObject WinText;

    private void Update()
    {
        if (isWin) Time.timeScale = 0;
        NextLevel();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WinText.SetActive(true);
            isWin = true;
            Time.timeScale = 0;
        }
    }

    private void NextLevel()
    {
        if (Input.GetKeyDown(KeyCode.N) && isWin)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
