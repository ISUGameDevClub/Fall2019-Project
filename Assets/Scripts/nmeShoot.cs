using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nmeShoot : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed = 10.0f;
    public float fireRate = 0.05f;
    private float nextFire = 0.0f;

    bool canShoot = true;

    private Vector3 target;
    Random r = new Random();
    int currentBullet = 0;
    GameObject[] b = new GameObject[10];

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        for (int n = 0; n < 5; n++)
        {
            GameObject bull = Instantiate(bulletPrefab) as GameObject;
            b[n] = bull;
            b[n].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

       


        Vector3 difference = player.transform.position- bulletStart.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (currentBullet > 5 - 1)
        {
            currentBullet = 0;
        }

        
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);

        

    }

    void fireBullet(Vector2 direction, float rotationZ)
    {
        if (Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;
            b[currentBullet].SetActive(true);
            b[currentBullet].transform.position = bulletStart.transform.position;
            b[currentBullet].transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
            b[currentBullet].GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
            
            currentBullet++;

        }
       

    }
}
