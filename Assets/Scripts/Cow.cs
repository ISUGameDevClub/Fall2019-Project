/*
    Cow has a starting position
    A "radius" from the start distance
    Add a pause for cow
    random.range


    for git bash commit to my branch, not master
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    System.Random randMove = new System.Random();
    // int randDir = randMove.Next(0,3);
    public float cowSpeed;
    private Rigidbody2D cowRigidbody;
    // private float movementInputX;
    // private float movementInputY;

    private Vector2 newScale;
    private bool facingRight = true;
    private bool facingLeft;
    private bool facingUp;
    private bool facingDown;
    public Sprite facingUpSprite;
    public Sprite facingDownSprite;
    public Sprite facingRightSprite;
    private SpriteRenderer cowSpriteRenderer;

    float horizontalRan;
    float verticalRan;
    
    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        cowRigidbody = GetComponent<Rigidbody2D>();
        cowSpriteRenderer = GetComponent<SpriteRenderer>();
        // newScale = transform.localScale;
    }

    private void seedMovement()
    {
        horizontalRan = randMove.Next(-30,30);
        verticalRan = randMove.Next(-30,30);
        lastTime = Time.time;
    }

    private void yoGabbagabba()
    {
        //float horizontalRan = randMove.Next(-30,30);
        //float verticalRan = randMove.Next(-30,30);
        //time???????
        //pause
        var direction = new Vector2(horizontalRan, verticalRan);
        cowRigidbody.transform.Translate(direction * cowSpeed);
        //Bounderies

        // flipFaceDirection();
        // movePlayer();
    }

    private void FixedUpdate()
    {
        //add time
        if (Time.time >= lastTime + 1)
        {
            seedMovement();
        } 

        yoGabbagabba();
        
    }

    // private void movePlayer()
    // {
    //     movementInputX = Input.GetAxisRaw("Horizontal");
    //     movementInputY = Input.GetAxisRaw("Vertical");
    //     playerRigidbody.velocity = new Vector2(movementInputX * playerSpeed, movementInputY * playerSpeed);
    // }

    // private void flipFaceDirection()
    // {
    //     if(movementInputX > 0 && !facingRight) //Facing right
    //     {
    //         facingRight = true;
    //         facingLeft = false;
    //         facingUp = false;
    //         facingDown = false;
    //         playerSpriteRenderer.sprite = facingRightSprite;
    //         newScale.x = 1;
    //         transform.localScale = newScale;
    //     }
    //     if(movementInputX < 0 && !facingLeft) //Facing left
    //     {
    //         facingRight = false;
    //         facingLeft = true;
    //         facingUp = false;
    //         facingDown = false;
    //         playerSpriteRenderer.sprite = facingRightSprite;
    //         newScale.x = -1;
    //         transform.localScale = newScale;
    //     }
    //     if(movementInputY > 0 && !facingUp) //Facing up
    //     {
            // facingRight = false;
            // facingLeft = false;
            // facingUp = true;
            // facingDown = false;
            // playerSpriteRenderer.sprite = facingUpSprite;
        // }
        // if(movementInputY < 0 && !facingDown) //Facing down
        // {
            // facingRight = false;
            // facingLeft = false;
            // facingUp = false;
            // facingDown = true;
            // playerSpriteRenderer.sprite = facingDownSprite;
        // }

}