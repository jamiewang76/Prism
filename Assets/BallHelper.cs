using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHelper : MonoBehaviour
{
    public GameObject ball;
    private bool BallIn = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BallIn == false)
        {
            Instantiate(ball);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            BallIn = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            BallIn = true;
        }
        
    }
}
