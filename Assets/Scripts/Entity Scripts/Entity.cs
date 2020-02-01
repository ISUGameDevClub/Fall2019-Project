using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    //Variables for entity.
    private HealthManager healthMan; //Can be used to store health variables and methods. 
                                     //IF private, need to set value in Start(). If public, can assign script from inspector. 
                                        //IDK what way is better/more efficient/better for performance.

    [SerializeField] //Shows field in inspector even though it is private.
    private int damageOutput;
    //private int armor;
    //private int factors; //What is this?
    //private Weapon currentWeapon;

    // Start is called before the first frame update
    public void Start()
    {
        healthMan = GetComponent<HealthManager>(); //Value assigned to attached HealthManager script.
    }

    // Update is called once per frame
    public virtual void Update() //Should be overriden by subclasses.
    {
        //Move()
        //Attack()
        //Etc..
    }

    public HealthManager GetHealthManager()
    {
        return healthMan;
    }

    public virtual void Die()  //Should be overwritten by subclasses.
    {
        Debug.Log("Entity died!");
    }

    //Look into C# Properties instead of Java Code methods.
    public int GetDamageOutput()
    {
        return damageOutput;
    }
    public void SetDamageOutput(int newDamageOutput)
    {
        damageOutput = newDamageOutput;
    }

    public virtual void Attack() //Should be overwritten by subclasses.
    {

    }

    /* In Player script that inherits from Entity.
    public void useGun();
    
    public void switchWeapon();
   
    public void useMelee();
   
    */
}
