
/*
 * Author: Parker Brown
 * Date Created: 10/2/19
 * Purpose:  Controls the spawning of enemies
 * Implementation:
 *      1. Create an empty game object e.g "Enemy_01_Manager", attach this script
 *      2. drag and drop enemy prefab into enemy field.  Create a new enemy manager for each type of enemy
 *      3. set spawnpoint size and fill with spawn point gameobjects (uniquely name each in heiarchy)
 *  See SpawnTriggerExample for how to start/stop spawning enemies from other scripts.
 * Tutorial: https://learn.unity.com/tutorial/survival-shooter-training-day-phases?projectId=5c514921edbc2a002069465e#5c7f8528edbc2a002053b71f
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;    //prefab of enemy to be spawned

    public float firstSpawn = 5f;     //time in seconds to first spawn
    public float spawnTime = 2f;       //time in seconds between spawns
    public Transform[] spawnPoints;    //where enemies spawn
    public bool spawnEnabled;          //see implementation, controls spawner
    public bool spawning;              //is object spawning enemies?

    //debug vars
    int n = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnabled = false;
        spawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnEnabled && !spawning)
        {
            InvokeRepeating("Spawn", firstSpawn, spawnTime);
            spawning = true;
        }

        if (!spawnEnabled && spawning)
        {
            CancelInvoke();
            spawning = false;
            n = 0;
        }

    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Debug.Log("Spawned Enemy " + ++n);
    }

}
