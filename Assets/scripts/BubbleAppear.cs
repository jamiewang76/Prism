using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleAppear : MonoBehaviour
{
    float next_spawn_time;
    public float break_min = 2f;
    public float break_max = 4f;
    public GameObject bubble;
    float breakTime;


    void Start()
    {
        breakTime = Random.Range(break_min, break_max);
        //start off with next spawn time being 'in 5 seconds'
        //next_spawn_time = Time.time + breakTime;

        InvokeRepeating("GenerateBubble", 1f, breakTime);
    }

    void Update()
    {
        //if (Time.time > next_spawn_time)
        //{
        //    breakTime = Random.Range(break_min, break_max);
        //    //do stuff here (like instantiate)
        //    Instantiate(bubble,transform.position, transform.rotation);
   
        // //increment next_spawn_time
        //    next_spawn_time += breakTime;
        //}


        breakTime = Random.Range(break_min, break_max);
    }

    void GenerateBubble()
    {
        Instantiate(bubble, transform.position, transform.rotation);
    }
}
