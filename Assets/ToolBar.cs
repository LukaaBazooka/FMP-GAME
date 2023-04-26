using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ToolBar : MonoBehaviour
{
    // Start is called before the first frame update



    public GameObject Tool1;
    public GameObject Tool2;
    public GameObject Tool3;
    public GameObject Tool4;
    public GameObject Tool5;
    public GameObject Tool6;
    public GameObject Tool7;
    public GameObject Tool8;
    public GameObject Tool9;

    public int key;


    // Update is called once per frame

    public void Start()
    {
        LeanTween.init(1000);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            key = 1;
            LeanTween.scale(Tool1, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            key = 2;

            LeanTween.scale(Tool2, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            key = 3;
            LeanTween.scale(Tool3, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            key = 4;
            LeanTween.scale(Tool4, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            key = 5;
            LeanTween.scale(Tool5, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            key = 6;
            LeanTween.scale(Tool6, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            key = 7;
            LeanTween.scale(Tool7, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha8))
        {
            key = 8;
            LeanTween.scale(Tool8, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool9, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
        else if (Input.GetKey(KeyCode.Alpha9))
        {
            key = 9;
            LeanTween.scale(Tool9, new Vector3(0.6f, 0.6f, 0.6f), 0.2f);
            LeanTween.scale(Tool1, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool3, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool4, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool5, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool6, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool7, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool8, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            LeanTween.scale(Tool2, new Vector3(0.5f, 0.5f, 0.5f), 0.2f);


        }
    }
   
}
