﻿public class Player : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //new shows that I am overiding this method from superclass Entity.
    public new void Attack()
    {
        UseGun();
        UseMelee();
    }

    public void UseGun()
    {
        //If player presses button to use gun, then fire that six shooter!
    }

    public void UseMelee() 
    {
        //If player presses button for melee, then whip them aliens!
    }
}
