using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    // Use this for initialization

    //create object    
    Rigidbody2D playerRigidbody2D;

    [Header("current horizontal speed")]
    //speed of horizonta
    public float speedX;

    [Header("maxspeed")]
    //maximum speed
    public float maxspeedX;

    public void ControlSpeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxspeedX, maxspeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }

    [Header("current horiztonal direction")]
    public float horizontalDirection;

    const string HORIZTONTAL = "Horizontal";

    [Header("horizontal force")]
    [Range(0, 250)]

    
    public float xForce;

    
    public float yForce;


    public bool jump
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }

    void tryjump()
    {
        if (isGround && jump)
        {
            playerRigidbody2D.AddForce(Vector2.up * yForce);
        }
    }

    [Header("distance")]
    [Range(0, 1f)]
    public float distance;

    [Header("check the initial point from the ground")]
    public Transform groundCheck;

    [Header("groundlayer")]
    public LayerMask groundLayer;

    public bool grounded;

    bool isGround
    {
        get
        {
            Vector2 Start = groundCheck.position;
            Vector2 end = new Vector2(Start.x, Start.y - distance);
            Debug.DrawLine(Start, end, Color.blue);
            grounded = Physics2D.Linecast(Start, end, groundLayer);
            return grounded;
        }
    }

    float speedY;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();

    }

    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZTONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
    }


     
    // Update is called once per frame
    void Update()
    {
        //if(playerRigidbody2D.)
        MovementX();
        ControlSpeed();
        tryjump();
        //speedX = playerRigidbody2D.velocity.x;
    }
}

