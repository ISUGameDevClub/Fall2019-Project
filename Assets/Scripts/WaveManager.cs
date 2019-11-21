
/*
 * Author: Parker Brown
 * Date Created: 10/30/19
 * Purpose:  Implement EnemyManager to spawn waves of enemies
 * Implementation:
 *      1. Create empty game object, attach script.
 *      2. Set m1 enemy manager game object in inspector.
 *      3. Set e1 and e2 enemy prefabs in inspector if applicable
 *   
 * Stretch Goals: 
 *      1.want to add pause wave until all enemies killed (requires enemy class implementation)
 *      2.add ui to inform player when waves start, how many enemies are left, etc.
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    /*  EnemyManager Data: EnemyManager.GetComponent<EnemyManager>().varName where varName:
     *      spawnEnabled: enable/disable spawning
     *      firstSpawn: time before first enemy spawns
     *      spawnTime: time between spawns
     *      
     * 
     */


    public GameObject manager1, manager2;   //enemy manager game objects in scene
    //public Enemy e1, e2;      //enemies, used to tweak stats if applicable
    private int wave;
    private float waveStart;
    private float waveEnd;

    //balancing knobs
    private int numEnemy1;
    //private int numEnemy2;                     //if multiple enemies
    private int difficulty = 5;  //1 <= x <= 10  

    //etc 
    EnemyManager m1, m2;    //scripts, set on start


    // Start is called before the first frame update
    void Start()
    {
        numEnemy1 = difficulty;
        //numEnemy2 = 0;
        wave = 1;
        m1 = manager1.GetComponent<EnemyManager>();
        //m2 = manager2.GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!m1.spawnEnabled)
        {
            Startwave();
        }
        else
        {
            if (Time.time >= waveEnd)
            {
                Endwave();
            }
        }

        /*
        if (!m2.spawnEnabled)
        {
            
        }
        else
        {
            
        }
        */
     

    }

    void Startwave()
    {
        float firstSpawn = 20 * (1.0f / difficulty);
        float spawntime = (1.0f / difficulty) * 3;
        numEnemy1 = (int)(numEnemy1 * (1.0 + (0.1 * difficulty))); //10% wave growth per difficulty, truncated
        m1.firstSpawn = firstSpawn;
        m1.spawnTime = spawntime;

        waveStart = Time.time;
        waveEnd = waveStart + firstSpawn + (spawntime * numEnemy1);

        m1.spawnEnabled = true;

        Debug.Log("Wave = " + wave + " starting in " + firstSpawn + " seconds.");
    }

    void Endwave()
    {
        Debug.Log("Wave " + wave + " Finished!");

        m1.spawnEnabled = false;
        wave++;
    }

}
