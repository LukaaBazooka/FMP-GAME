using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public RawImage images;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.alpha(images.rectTransform, 0f, 5f).setEaseInOutQuad();

    }

    // Update is called once per frame

}