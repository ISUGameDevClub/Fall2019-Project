using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //New shows that I am overiding this method from superclass Entity. Maybe OVERRIDE?
    public override void Attack()
    {
        //Go crazy!
        //Get those cattle!
    }

    public override void Die()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit: " + collision.name + "!");
        Entity entity = collision.GetComponent<Enemy>();
        //entity = collision.GetComponent<Livestock>(); //Checks if collided with livestock.
        if (entity != null) //Does something if collided with livestock.
        {
            entity.GetComponent<HealthManager>().TakeDamage(entity.GetDamageOutput());
            Destroy(gameObject);
        }
        //If hit wall

    }
}
