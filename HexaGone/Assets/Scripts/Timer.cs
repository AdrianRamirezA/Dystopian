using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    bool timerActive = false;
    float currentTime;
    public int startMinutes;
    public Text currentTimeText;

    LevelLoader levelLoader;
    public GameObject Time_Canvas;
    public GameObject pcollider;

    void Awake()
    {
        levelLoader = Time_Canvas.GetComponent<LevelLoader>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartTimer();
        currentTime = startMinutes * 19;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0)
            {
                levelLoader.LoadNextLevel();
                timerActive = false;
                pcollider.SetActive(false);
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }
    
    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }

}
