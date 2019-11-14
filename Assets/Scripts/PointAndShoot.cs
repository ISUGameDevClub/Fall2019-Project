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

    public AudioClip impact;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        

        
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
            GameObject b = Instantiate(bulletPrefab) as GameObject;
            audioSource.PlayOneShot(impact, 1.0F);
            b.transform.position = bulletStart.transform.position;
            b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
            b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
            canShoot = false;
        }
        else if(canShoot == false)
        {
            canShoot = true;
        }
    }
   
}

