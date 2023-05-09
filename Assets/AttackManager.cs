using System.Collections;
using System.Collections.Generic;
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Equipped = ToolBar.key;

        if (Input.GetKeyDown(OnClick) && Equipped == 3 && ! action && ! owlcoodlwon)
        {
            Attack();
        }
        


    }
    IEnumerator Attack()
    {
        action = true;
        owlcoodlwon= true;
        animator.SetBool("Attacking", true);
        Slash.Play();

        animator.Play("Owlslash");
        yield return new WaitForSeconds(1f);
        action = false;
        animator.SetBool("Attacking", false);

        yield return new WaitForSeconds(8);
        owlcoodlwon = false;

    }
}
