using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public Image whiteFade;
    public float timeNeeds = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("switch!");
        if (other.CompareTag("Player"))
        {
            FadeScene();
        }
    }

    void SceneSwitch()
    {
        SceneManager.LoadScene("CityBottom");
    }

    void FadeScene()
    {
        whiteFade.CrossFadeAlpha(1, timeNeeds, false);

        Invoke("SceneSwitch", 1f);
    }
}
