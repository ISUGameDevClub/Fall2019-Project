using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Change Alien to enemy
public class AlienMovement : MonoBehaviour
{

    private GameObject[] cows;
    private GameObject[] aliens;
    private GameObject targetedCow;
    public float speed;

    void Start() {
        cows = GameObject.FindGameObjectsWithTag("Cow");
        aliens = GameObject.FindGameObjectsWithTag("Alien");
        targetedCow = getClosestCow();
    }


    void Update() {
        Debug.Log(cows[0].transform.position);
        Debug.Log(aliens[0].transform.position);

        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, targetedCow.transform.position, step);
    }

    // TODO: If there's a closer cow, alien should path to that one instead.
    // private GameObject findNewTarget() {
    //     float[] cowDistances = new float[cows.Length];
    //     for (int i = 0; i < cows.Length; i++) {
    //         Vector2.Distance
    //     }
    // }


    // Return index of closest cow instead
    GameObject getClosestCow() {
        GameObject closest = null;
        Vector3 currentPos = transform.position;
        // We can set the initial value to the first cow.
        float minDist = Vector2.Distance(cows[0].transform.position, currentPos);

        // Check distance of every cow, replacing minDist if a closer cow is found 
        foreach (GameObject cow in cows) {
            float dist = Vector2.Distance(cow.transform.position, currentPos);
            if (dist < minDist) {
                closest  = cow;
                minDist = dist;
            }
        }
        return closest;
    }
}
