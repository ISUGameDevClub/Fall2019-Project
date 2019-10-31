﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject crosshairs;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed = 30.0f;
    

    bool canShoot = true;

    private Vector3 target;
    //int BULLETS = 10;
    int currentBullet = 0;
    GameObject[] b = new GameObject[10];
    
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        for (int n = 0; n < 10; n++)
        {
            GameObject bull = Instantiate(bulletPrefab) as GameObject;
            b[n] = bull;
            b[n].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (currentBullet > 10 - 1)
        {
            currentBullet = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                direction.Normalize();
                fireBullet(direction, rotationZ);
            
        }
     
    }
    
    void fireBullet(Vector2 direction, float rotationZ)
    {
        if (canShoot == true)
        {

            b[currentBullet].SetActive(true);
            b[currentBullet].transform.position = bulletStart.transform.position;
            b[currentBullet].transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
            b[currentBullet].GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
            canShoot = false;
            currentBullet++;

        }
        else if(canShoot == false)
        {
            canShoot = true;
        }
        
    }
   
}

