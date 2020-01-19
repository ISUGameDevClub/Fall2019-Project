
/*
 * Author: Parker Brown
 * Date Created: 10/9/19
 * Purpose:  An example to show how to spawn enemies using an enemy manager
 * Implementation:
 *      1. drag an enemy manager game object in the scene to a variable
 *      2. access spawnEnabled as seen on line 32
 *      
 *      Note that this script is an example implementation ONLY.  How you 
 *      trigger (or stop) spawns is up to you.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTriggerExample : MonoBehaviour
{
    public GameObject EnemyManager;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Trigger());
    }

    IEnumerator Trigger()
    {
        yield return new WaitForSeconds(.2f);
        Debug.Log("Set spawnEnabled = true");
        EnemyManager.GetComponent<EnemyManager>().spawnEnabled = true;
    }
}
