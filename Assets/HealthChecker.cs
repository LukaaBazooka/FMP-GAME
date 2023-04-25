using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public float MaxHealth;
    public float  CurrentHealth;
    public Slider HealthSlider;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float HealthLow = CurrentHealth / 100;
        HealthSlider.value = HealthLow;
     

    }

}
