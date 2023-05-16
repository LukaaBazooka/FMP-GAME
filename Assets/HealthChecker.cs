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
    public float Multiplier;

    public static float StaticMulti;
    public static float MaxStaticHealth;
    public static float CurrentHealth;
    public Slider HealthSlider;
    float curvel = 0;

    public AudioSource Helmeton;
    public AudioSource Helmetoff;



    public Renderer Helmet;

    private KeyCode Mouse1Key = KeyCode.Mouse0;
    public int Equipped;

    private bool HelmetOn = false;
    void Start()
    {
        MaxStaticHealth = MaxHealth;

        CurrentHealth = CurrentGUIHealth;
        StaticMulti = Multiplier;
        Helmet.enabled = false;

        StartCoroutine(Regen());

    }
    float percent;
    // Update is called once per frame
    void Update()
    {
        Equipped = ToolBar.key;

        if (Input.GetKeyDown(Mouse1Key) && Equipped == 8)
        {
            if (HelmetOn)
            {
                Helmetoff.Play();
                //Visuals
                Helmet.enabled = false;
                HelmetOn = false;
                //get the percent of max hp
                percent = CurrentGUIHealth;

                //Changes MaxHealth to 100
                MaxHealth = 100;
                //debug it
                Debug.Log(percent + " Percent");
                //change regen multiplier
                Multiplier = 1f; ;
                //Current heath. 1.5 is 1 percent. so 1.5 x percent gives you your players health
                float percentone = 100.0f / 150.0f;
                print(percentone);
                CurrentGUIHealth = percentone * percent;
                Debug.Log(CurrentGUIHealth + " Max Health with it off");

                CurrentHealth = CurrentGUIHealth;


            }
            else
            {
                Helmeton.Play();

                //Visuals
                Helmet.enabled = true;
                HelmetOn = true;
                //get the percent of max hp
                percent = CurrentGUIHealth;
                
                //Changes MaxHealth to 150
                MaxHealth = 150;
                //debug it
                Debug.Log(percent + " Percent");
                //change regen multiplier
                Multiplier = 2.5f; ;
                //Current heath. 1.5 is 1 percent. so 1.5 x percent gives you your players health
                float percentone = 150.0f / 100.0f;
                print(percentone);
                CurrentGUIHealth = percentone * percent;
                Debug.Log(CurrentGUIHealth + " Max Health With it on");

                CurrentHealth = CurrentGUIHealth;

            }
        }

        float HealthLow = CurrentHealth / MaxHealth;

        float currentscore = Mathf.SmoothDamp(HealthSlider.value, HealthLow,ref curvel,100 * Time.deltaTime);

        HealthSlider.value = currentscore;
        CurrentGUIHealth = CurrentHealth;
        MaxStaticHealth = MaxHealth;


    }

    public static void Damage(float damage)
    {
        LeanTween.value(CurrentHealth, CurrentHealth -= damage, 2f).setEaseInOutQuad();

        if (CurrentHealth - damage <=0)
        {
            CurrentHealth= 0;
        }
        if (CurrentHealth - damage > MaxStaticHealth+10)
        {
            CurrentHealth= MaxStaticHealth;
        }

    }

    public static IEnumerator Regen()
    {
     
        while (true)
        {
            if (CurrentHealth < MaxStaticHealth)
            {
                //Debug.Log("Regen");
                CurrentHealth += 0.4f * StaticMulti;
                yield return new WaitForSeconds(0.5f);

            }
            else
            {

                yield return new WaitForSeconds(0.5f);

            }
            


        }
    }

}
