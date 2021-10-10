using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnKang : MonoBehaviour
{
    public GameObject AnKang_ps;

    // Start is called before the first frame update
    void Start()
    {
        AnKang_ps.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hand")
        {
            AnKang_ps.SetActive(true);
            //Invoke("TurnOff", 10f);
        }
    }

    void TurnOff()
    {
        AnKang_ps.SetActive(false);
    }
}
