using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0, 0);
    
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController PlayerControllerScript;

    void Start()
    {
        //zorgt dat voorwerpen blijven spawnen elke 2 seconden met een 2 seconde vertraging op de start
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    void SpawnObstacle()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

        // Update is called once per frame
    void Update()
    {
        
    }
}
