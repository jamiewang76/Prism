using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleFloat : MonoBehaviour
{
    public float startingSpeed = 0.2f;
    public float speed = 1f;
    float startTime;
    public bool isGrabbed = false;
    public Vector3 floatMove;


    // Xu: The Climber
    private Climber _climber;

    private GameObject hand;

    public void SetClimber(Climber climber)
    {
        _climber = climber;
    }

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        hand = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime < 3f)
        {
            transform.position += new Vector3(0, startingSpeed * Time.deltaTime, 0);
        }
        else
        {
            floatMove = new Vector3(0, speed * Time.deltaTime, 0);
            transform.position += floatMove;

            // Xu: If we have a Climber attached, we also want to update its position
            if (_climber)
            {
                _climber.gameObject.transform.position += floatMove;
            }
        }


        if(transform.position.y > hand.transform.position.y + 10f)
        {
            Destroy(gameObject);
        }

    }
}