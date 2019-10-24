using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public int speed;
    //private Enemy enemy;
    private Entity entity;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit: " + collision.name + "!");
        //entity = collision.GetComponent<Enemy>();
        entity = collision.GetComponent<Player>();
        if (entity!= null)
        {
            entity.GetComponent<HealthManager>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
