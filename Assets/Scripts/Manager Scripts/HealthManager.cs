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

    private Entity owner;

    public AudioClip hurtSound;
    AudioSource audioSource;

    public void Start()
    {
        owner = GetComponentInParent<Entity>();
        Debug.Log(owner.name);
        owner.Start();
        audioSource = GetComponent<AudioSource>();
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
    public void SetCurrentHealth(int newHealth)
    {
        currentHealth = newHealth;
    }

    public void TakeDamage(int damage)
    {
        audioSource.PlayOneShot(hurtSound, 0.7F);
        SetCurrentHealth(GetCurrentHealth() - damage);
        CheckIfDead();
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
            Die();
        }
    }
    public void Die()
    {
        //What happens when that entity dies?
        owner.Die(); //Managed by Entity and all subclasses so it can be overwritten.
        Debug.Log("Somebody died!");
    }

    public void Heal(int healAmount)
    {
        SetCurrentHealth(GetCurrentHealth() + healAmount);
        if(GetCurrentHealth() > GetMaxHealth())
        {
            SetCurrentHealth(GetMaxHealth());
        }
    }
}
