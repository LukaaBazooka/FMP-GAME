using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{   
    public RawImage images;
    public AudioSource PlaySound;

    public void Runs()
    {
        StartCoroutine(PlayGame());
    }

    public IEnumerator PlayGame()
    {
        PlaySound.Play();
        LeanTween.alpha(images.rectTransform, 1f, 2f);

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene");
    }




}
