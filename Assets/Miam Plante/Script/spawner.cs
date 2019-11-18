using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject flower;
    public float spawnDelay = 5f;
    private GameObject instanceFlower;
    private bool respawning = false;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(flower, transform);
        
    }

    
    void SpawnObject()
    {
        Instantiate(flower, transform);
        respawning = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0 && !respawning)
        {
            print("hey!");
            respawning = true;
            Invoke("SpawnObject", spawnDelay);
        }
    }
}
