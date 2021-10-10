using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disappear", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disappear()
    {
        gameObject.SetActive(false);
    }
}
