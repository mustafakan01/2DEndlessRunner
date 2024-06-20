using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gamePanel;
    private bool isTimeStopped=true;
    
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        isTimeStopped = false;
        gamePanel.SetActive(false);

    }

}
