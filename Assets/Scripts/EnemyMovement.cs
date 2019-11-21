
/*
 * Author: Parker Brown
 * Date Created: 11/13/19
 * Purpose:  Move enemies toward player/cows
 * Implementation:
 *      1. attatch script to enemy PREFAB
 *      2. add tag "Player" to player gameobject
 *      3. add the tag "Cow" to the cow prefab BEFORE populating scene with cows
 *          3a. all cows must be in scene at game start (ie: not spawned via script)
 *      4. set speed to taste in inspector (start with ~.05 for starters)
 *   
 * Useful guides: finding targets: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
 *                movement: https://answers.unity.com/questions/56251/make-object-move-tofollow-another-object-plus-turn.html
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject[] targets;
    private GameObject target;
    public float speed;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        target = null;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        target = FindTarget();
        Move();
    }

    GameObject FindTarget()
    {
        targets = GameObject.FindGameObjectsWithTag("Cow");
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        Vector3 diff;
        foreach(GameObject go in targets)
        {
            diff = go.transform.position - position;
            float current = diff.sqrMagnitude;
            if(current < distance)
            {
                target = go;
                distance = current;
            }
        }

        diff = Player.transform.position - position;
        if (diff.sqrMagnitude < distance)
            target = Player;

        return target;
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
