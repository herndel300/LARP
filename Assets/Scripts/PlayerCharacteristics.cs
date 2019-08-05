using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacteristics : MonoBehaviour
{
    public int health = 6;
    public Image healthBar;
    public Sprite[] healthBarImages;
    public GameObject gameOverMenu;

    public void HandleHealth()
    {
        if(health == 6)
        {
            healthBar.sprite = healthBarImages[0];
        }

        if (health == 5)
        {
            healthBar.sprite = healthBarImages[1];
        }

        if (health == 4)
        {
            healthBar.sprite = healthBarImages[2];
        }

        if (health == 3)
        {
            healthBar.sprite = healthBarImages[3];
        }

        if (health == 2)
        {
            healthBar.sprite = healthBarImages[4];
        }

        if (health == 1)
        {
            healthBar.sprite = healthBarImages[5];
        }

        if (health <= 0)
        {
            healthBar.sprite = healthBarImages[6];
            Time.timeScale = 0;
            gameOverMenu.SetActive(true);
            health = 6;           
        }
    }

    void Update()
    {
        HandleHealth();
    }

}
