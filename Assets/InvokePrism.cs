using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePrism : MonoBehaviour
{
    public GameObject prism;
    public float InvokePrismTime = 50f;
    public float FallSpeed;
    private Vector3 move;
    public bool StartFall = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PrismAppear", InvokePrismTime);

    }

    // Update is called once per frame
    void Update()
    {
        if(StartFall)
        {
            move = new Vector3(0, -FallSpeed * Time.deltaTime, 0);
            transform.position += move;
        }
        
    }

    void PrismAppear()
    {
        GetComponent<Fly>().enabled = false;
        Instantiate(prism);
        StartFall = true;
    }
}
