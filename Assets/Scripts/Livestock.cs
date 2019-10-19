using UnityEngine;

public class Livestock : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Die()
    {
        Debug.Log("Mooooo!");
        Destroy(gameObject);
    }

    //public override void Attack()
    //{
        //Bruh.
        //I cant fight man.
    //}
}
