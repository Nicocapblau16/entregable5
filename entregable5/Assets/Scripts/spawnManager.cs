using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    public float startDelay = 0.5f;
    public float repeatRate = 5.0f;
    private int randLow = -11;
    private int randHigh = 11;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate); //invocacion objetos
    }

  
    public void SpawnObstacle() 
    {

        randomY = Random.Range(randLow, randHigh); //random num entre -10 y 10
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);  //posición nuevo spawn
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);  //instanciación
         
    }
}
