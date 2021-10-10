using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_script : MonoBehaviour
{
    public bool turn = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "particles")
        {
            turn = true;
            Debug.Log("triggered");
        }
    }
}
