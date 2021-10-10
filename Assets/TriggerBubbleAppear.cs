using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBubbleAppear : MonoBehaviour
{
    public GameObject bubble_appear;
    // Start is called before the first frame update
    void Start()
    {
        bubble_appear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bubble_appear.SetActive(true);
        }
    }
}
