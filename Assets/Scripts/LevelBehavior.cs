using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBehavior : MonoBehaviour
{
    public bool waveIsOver = false;
    public Text enemiesRemainText;
    public Text waveNoText;
    public Text killCountText;
    public int enemiesRemaining;
    public int killCount = 0;

    void HandleWaveNumber()
    {
        if(killCount < 10)
        {
            waveNoText.text = "Wave: 1";
        }

        if(killCount >= 10 && killCount < 25)
        {
            waveNoText.text = "Wave: 2";
        }

        if (killCount >= 25 && killCount < 50)
        {
            waveNoText.text = "Wave: 3";
        }
    }

    void Update()
    {
        HandleWaveNumber();
        killCountText.text = "Kill Count: " + killCount.ToString();
    }
}
