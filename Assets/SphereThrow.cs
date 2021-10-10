using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereThrow : MonoBehaviour
{
    private Vector3 StartPosition;
    private bool hasBall = false;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != StartPosition && hasBall == false)
        {
            Invoke("MakeBall", 3f);
            hasBall = true;
        }
    }

    void MakeBall()
    {
        Instantiate(ball);
    }
}
