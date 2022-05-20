using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    PauseMenu pauseMenu;
    public GameObject canvas;

    void Awake()
    {
        pauseMenu = canvas.GetComponent<PauseMenu>();
    }
  
    public void NextLevel()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void MenuLevel()
    {
        StartCoroutine(LoadLevel(0));
        pauseMenu.Resume();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(transitionTime);
        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }
}
