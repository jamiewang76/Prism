using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Left_hand : MonoBehaviour
{
    public GameObject Camera;
    private float counter = 0;

    public float upSpeed;
    public float fallSpeed;

    private Vector3 originalPosition;
    private Vector3 fallPosition;
    public bool boost = false;

    public float acc;


    public bool started = false;
    

    void Start()
    {
        originalPosition = Camera.transform.position;
    }

    void Update()
    {
        if(started == false)
        {
            Camera.transform.position = originalPosition;
        }
        if(boost == false && started == true)
        {
            counter += Time.deltaTime;
            Camera.transform.position = new Vector3(originalPosition.x, originalPosition.y - counter * fallSpeed, originalPosition.z);
        }
        if(boost == true)
        {
            started = true;
            counter += Time.deltaTime;
            upSpeed -= acc;
            Camera.transform.position = new Vector3(fallPosition.x, fallPosition.y + counter * upSpeed, fallPosition.z);
            if(upSpeed <= 0)
            {
                MakeBoostFalse();
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        fallPosition = Camera.transform.position;
        boost = true;
        counter = 0;
        
    }

    void MakeBoostFalse()
    {
        originalPosition = Camera.transform.position;
        boost = false;
        counter = 0;
    }
}
