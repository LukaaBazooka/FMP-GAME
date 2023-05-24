using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlowEfecr : MonoBehaviour
{
    // Start is called before the first frame update
    public Image images;

    void Start()
    {
        StartCoroutine(Glow());
    }

    public IEnumerator Glow()
    {
      while (true)
        { 
            yield return new WaitForSeconds(0.5f);

            LeanTween.alpha(images.rectTransform, 1f, 3f).setEaseInOutQuad();
            LeanTween.scale(images.rectTransform, new Vector3(1.13614035f, 36.5135078f, 1f), 3f).setEaseInOutQuad();
            yield return new WaitForSeconds(2.5f);
            LeanTween.alpha(images.rectTransform, 0f, 3f).setEaseInOutQuad();
            yield return new WaitForSeconds(.5f);

            LeanTween.scale(images.rectTransform, new Vector3(0.893785715f, 11.4869394f, 1f), 3f).setEaseInOutQuad();
            yield return new WaitForSeconds(2f);


        }
    }
    // Update is called once per frame

}
