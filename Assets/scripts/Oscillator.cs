using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float timeCounter = 0;

    float timeCounter2 = 0;

    public float forwardSpeed;
    public float circularSpeed;
    public float width1;
    public float width2;
    public float height1;
    public float height2;

    bool getZ = false;
    float CurrentZ;

    public float forwardSpeed2;
    public float addSpeed;

    public GameObject trigger_object;

    float x;
    float y;
    float z;

    float counter = 0;

    float counter2 = 0;
    Vector3 oldPosition;
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger_object.GetComponent<Turn_script>().turn == false)
        {
            oldPosition = gameObject.transform.position;
            timeCounter += Time.deltaTime * circularSpeed;

            x = Mathf.Cos(timeCounter) * Random.Range(width1, width2);
            y = Mathf.Sin(timeCounter) * Random.Range(height1, height2);

            counter += Time.deltaTime;

            newPosition = new Vector3(x, y, counter * forwardSpeed);
            transform.position = Vector3.Lerp(oldPosition, newPosition, 0.5f);
        }

        if (trigger_object.GetComponent<Turn_script>().turn == true)
        {
            if(getZ == false)
            {
                CurrentZ = gameObject.transform.position.z;
                getZ = true;
            }
            //get last z position

            forwardSpeed2 += addSpeed;

            oldPosition = gameObject.transform.position;
            timeCounter2 += Time.deltaTime * circularSpeed;

            x = Mathf.Cos(timeCounter) * Random.Range(width1, width2);
            z = Mathf.Sin(timeCounter) * Random.Range(height1, height2);

            counter2 += Time.deltaTime;

            newPosition = new Vector3(x, y-counter2 * forwardSpeed2 , CurrentZ+z);
            transform.position = Vector3.Lerp(oldPosition, newPosition, 0.5f);
        }
    }

    
}
