using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameObject head;
    public GameObject rightHand;

    public GameObject whale;
    public float InvokeWhaleTime = 40f;
    

    private float flyingSpeed = 0.1f;
    private bool isFlying = false;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("AppearWhale", InvokeWhaleTime);
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfFlying();
        FlyIfFlying();
    }

    void FlyIfFlying()
    {
        if (isFlying == true)
        {
            Vector3 FlyDirection = rightHand.transform.position - head.transform.position;
            transform.position += FlyDirection.normalized * flyingSpeed;
        }
    }

    void CheckIfFlying()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            isFlying = true;
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            isFlying = false;
        }

    }

    void AppearWhale()
    {
        Instantiate(whale);
        Debug.Log("trigger whale");
    }
}
