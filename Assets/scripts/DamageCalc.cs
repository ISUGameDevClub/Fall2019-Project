using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalc : MonoBehaviour {

    private int damage;
    private int armor;
    public HealthManager healthM;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getDamageLit()
    {
        int damageLit = damage - armor;
        if (damageLit < 0)
            damageLit = 0;

        //Because RNG is epic, but I don't know how to implement it :(
        // else  
        //      damageLit = Random.Range(0.70f,1.20f)(damageLit);

        return damageLit;
    }


    public void takeDamage()
    {
        int currentHealth = healthM.GetCurrentHealth();
        int damageLit = getDamageLit();

        if (currentHealth - damageLit <= 0)
            healthM.SetCurrentHealth(0);
        else
            healthM.SetCurrentHealth(currentHealth - damageLit);
    }
}
