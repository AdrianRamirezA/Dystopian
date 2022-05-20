using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    public GameObject gameOverMenuUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        gameOverMenuUI.SetActive(true);
    }

    public void Retry()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void MenuRetry()
    {
        gameOverMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
