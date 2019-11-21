using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMovement : MonoBehaviour
{
    System.Random randMove = new System.Random();
    public float cowSpeed;
    private Rigidbody2D cowRigidbody;

    private Vector2 newScale;
    private SpriteRenderer cowSpriteRenderer;
    
    void Start()
    {
        cowRigidbody = GetComponent<Rigidbody2D>();
        cowSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // Random numbers are selected for the X and Y axis to path the cow. 
        float horizontalRan = randMove.Next(-5,5);
        float verticalRan = randMove.Next(-5,5);
        var direction = new Vector2(horizontalRan, verticalRan);
        cowRigidbody.velocity = direction * cowSpeed;
    }
}