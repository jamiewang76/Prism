using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleAppear : MonoBehaviour
{
    private GameObject Camera;
    private Vector3 StartPosition;
    public float WhaleSpeed = 0.5f;
    private Vector3 move;

    private float Delta;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Vector3 FaceDirection = Camera.transform.forward;
        StartPosition = new Vector3(-FaceDirection.x * 100, Camera.transform.position.y + 10, -FaceDirection.z * 10);
        transform.position = StartPosition;

        Delta = Camera.transform.position.x - StartPosition.x;
        //Debug.Log(StartPosition);
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3((Delta * WhaleSpeed ) * Time.deltaTime, 0, 0);
        transform.position += move;
        //Debug.Log(transform.position);
    }
}
