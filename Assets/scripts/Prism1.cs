using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Prism1 : MonoBehaviour
{
    public float rotationSpeed = 3f;
    public Image whiteFade;
    public float timeNeeds = 2f;
    private GameObject Camera;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        StartPosition = new Vector3(Camera.transform.position.x, Camera.transform.position.y - 20, Camera.transform.position.z);
        transform.position = StartPosition;

        whiteFade = GameObject.FindGameObjectWithTag("Canvas").GetComponentInChildren<Image>();
        whiteFade.canvasRenderer.SetAlpha(0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("MainCamera"))
        {
            //Image.GetComponent<Animator>().SetBool("fade", true);

            //Invoke("SwitchScene", 1f);

            //whiteFade.canvasRenderer.SetAlpha(1f);
            FadeScene();
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Room");
    }

    void FadeScene()
    {
        whiteFade.CrossFadeAlpha(1, timeNeeds, false);

        Invoke("SwitchScene", 2f);
    }
}
