using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBehavior : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject enemy;
    public GameObject gameController;
    public Animator portalController;
    public float timer;

    void Start()
    {
        portalController = GetComponent<Animator>();
        timer = Time.time + 1;
    }

    public void SpawnEnemy()
    {
        if (timer < Time.time &&
                gameController.GetComponent<LevelBehavior>().waveIsOver == false)
        {
            portalController.Play("PortalAnimation");
            Instantiate(enemy, spawnpoint.transform.position, Quaternion.identity);
            timer = Time.time + 1;
        }
    }

    private void Update()
    {
        SpawnEnemy();
    }
}

    

    
    

