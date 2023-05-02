using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class HealthChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public float MaxHealth;
    public float CurrentGUIHealth;

    public static float CurrentHealth;
    public Slider HealthSlider;

    void Start()
    {
        CurrentHealth = CurrentGUIHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float HealthLow = CurrentHealth / 100;
        HealthSlider.value = HealthLow;


    }

    public static void Damage(float damage)
    {
        for (int i = 0; i < damage/10 ; i++)
        {
            CurrentHealth -= 10;
            Task.Delay(400);

        }
        CurrentHealth -= damage;
        Debug.Log(CurrentHealth);
    }
}
