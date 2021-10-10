using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Prism : MonoBehaviour
{
    public float rotationSpeed = 3f;
    public Image whiteFade;
    public float timeNeeds = 2f;

    // Start is called before the first frame update
    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //Image.GetComponent<Animator>().SetBool("fade", true);

            //Invoke("SwitchScene", 1f);

            //whiteFade.canvasRenderer.SetAlpha(1f);
            FadeScene();
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("OceanSky");
    }

    void FadeScene()
    {
        whiteFade.CrossFadeAlpha(1, timeNeeds, false);

        Invoke("SwitchScene", 2f);
    }
}
