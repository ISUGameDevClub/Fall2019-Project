using UnityEngine;

public class Enemy : Entity
{

    private Transform targetFolderTransform;

    // Start is called before the first frame update
    void Start()
    {
        targetFolderTransform = GameObject.FindGameObjectWithTag("Enemies Folder").transform;
        transform.SetParent(targetFolderTransform, false);
    }

    // Update is called once per frame
    public override void Update()
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
}
