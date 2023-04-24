using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bheaviourcrouch : StateMachineBehaviour
{


    [SerializeField]
    private float _time_UntilBored;

    [SerializeField]
    private int _NumverOfBoredAnimations;
    private bool isBored;
    private float idletime;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetIdle(animator);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!isBored) 
        {
            idletime += Time.deltaTime;
            if (idletime > _time_UntilBored)
            {
                isBored= true;
                int Boredanim = Random.Range(1, _NumverOfBoredAnimations + 1);

                animator.SetFloat("BoredAnimation", Boredanim);
            }
        }

        else if (stateInfo.normalizedTime % 1 > 0.98)
        {
            ResetIdle(animator);
        }
    }
    private void ResetIdle(Animator animator)
    {
        isBored= false;
        idletime = 0;

        animator.SetFloat("BoredAnimation", 0);
    }
}
