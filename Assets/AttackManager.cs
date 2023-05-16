using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static PlayerMovement;

public class AttackManager : MonoBehaviour
{
    // Start is called before the first frame update

    public bool action;
    public bool Stun;
    public Animator animator;
    private PlayerMovement pm;

    private KeyCode OnClick = KeyCode.Mouse0;
    public int Equipped;

    private bool owlcoodlwon;
    public AudioSource Slash;

    private bool potionCD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Equipped = ToolBar.key;

        if (Input.GetKeyDown(OnClick) && Equipped == 3 && ! action && ! owlcoodlwon && Grappling.grapplingtwo && Grappling.ischargrappled2)
        {
   
            Slash.Play();

            StartCoroutine(Attack());

        }
        else if (Input.GetKeyDown(OnClick) && Equipped == 1) HealthChecker.Damage(10f);

        else if (Input.GetKeyDown(OnClick) && Equipped == 9 && potionCD == false)
        {
            potionCD = true;

            HealthChecker.Damage(-10f);
            StartCoroutine(Cooldown(2f,"Potion"));            
        }



    }
    IEnumerator Attack()
    {
        action = true;
        owlcoodlwon= true;
        animator.SetBool("Attacking", true);

        animator.Play("Owlslash");
        yield return new WaitForSeconds(1f);
        action = false;
        animator.SetBool("Attacking", false);

        yield return new WaitForSeconds(8);
        owlcoodlwon = false;

    }
    IEnumerator Cooldown(float CD,string type)
    {
        if (type == "Potion")
        {
            yield return new WaitForSeconds(CD);
            potionCD = false;

        }
    }
}
