using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climber : MonoBehaviour
{

    public float gravity = 45.0f;
    public float sensitivity = 45.0f;
    private Hand currentHand = null;
    private CharacterController controller = null;

    public Vector3 handStartPosition;
    public Vector3 handEndPosition;

    private float startTime;
    private float endTime;

    public float boost;
    public float slowBoost = 0.001f;

    private bool boostNow = false;

    public GameObject hand;
    public GameObject bubble;

    public GameObject groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;

    private void Awake()
    {

        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.transform.position, groundDistance, groundMask);
        if(!isGrounded && currentHand == null)
        {
            Vector3 movement = Vector3.zero;
            movement.y -= gravity * Time.deltaTime;
            controller.Move(movement * Time.deltaTime);
        }
        
        //CalculateMovement();
    }
    private void CalculateMovement()
    {
        Vector3 movement = Vector3.zero;
        //if (currentHand)
        //{
        //    movement += currentHand.Delta * sensitivity;


        //    //controller.Move(movement * Time.deltaTime);
        //}


        //if (movement == Vector3.zero)
        //{
        //    //boostNow = false;
        //    movement.y -= gravity * Time.deltaTime;
        //    //controller.Move(movement * Time.deltaTime);
        //}

        //controller.Move(movement * Time.deltaTime);
        controller.Move(movement);
    }
    public void SetHand(Hand hand)
    {
        //handStartPosition = hand.transform.position;
        //startTime = Time.time;


        if (currentHand)
            currentHand.ReleasePoint();

        currentHand = hand;

    }
    public void ClearHand()
    {
        //endTime = Time.time;
        //handEndPosition = currentHand.transform.position;
        currentHand = null;
        //boostNow = true;
    }

    public void ChangeBoost()
    {
        boostNow = false;
    }
}