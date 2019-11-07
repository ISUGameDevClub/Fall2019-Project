using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int currentHealth;
    private bool isDead = false;

    public HealthManager healthMan; //this is an object of HealthManager

    // Start is called before the first frame update
    void Start()
    {
        
    }


    //New healthM = HealthManager(ldmf;lasd)


    // Update is called once per frame
    void Update()
    {
        //Check if dead.
        CheckIfDead();
        DoIfDead();
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }
    public void SetMaxHealth(int newMaxHealth)
    {
        maxHealth = newMaxHealth;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    //Call this when making damage manager? Or when damaged?.
    public void SetCurrentHealth(int newHealth)
    {
        currentHealth = newHealth;
    }

    public bool GetIsDead()
    {
        return isDead;
    }
    public void SetIsDead(bool newIsDead)
    {
        isDead = newIsDead;
    }

    public void CheckIfDead()
    {
        if(GetCurrentHealth()<=0)
        {
            SetIsDead(true);
        }
    }
    public void DoIfDead()
    {
        //What happens when that entity dies?
        if(GetIsDead() == true)
        {
            //Do something...
            Debug.Log("Somebody died!");
        }
    }

    public void Heal(int healAmount)
    {
        if(GetCurrentHealth() + healAmount >= GetMaxHealth())
        {
            SetCurrentHealth(GetMaxHealth());
        }
        else
        {
            SetCurrentHealth(GetCurrentHealth() + healAmount);
        }
    }
}
