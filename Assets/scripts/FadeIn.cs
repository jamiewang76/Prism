using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image whiteFade;
    public float timeNeeds;
    // Start is called before the first frame update
    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(1f);
        FadeScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FadeScene()
    {
        whiteFade.CrossFadeAlpha(0, timeNeeds, false);
    }
}
