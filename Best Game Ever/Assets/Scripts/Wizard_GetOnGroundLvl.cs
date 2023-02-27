using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_GetOnGroundLvl : StateMachineBehaviour
{
    private Wizard wizard;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard = animator.GetComponent<Wizard>();
        wizard.StartCoroutine(GetOnGroundLvl());
        animator.SetInteger("randomAttack_i", Random.Range(0, 3));
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard.isHovering = true;
    }

    private IEnumerator GetOnGroundLvl()
    {
        Debug.Log("Puteti ataca!");
        wizard.isHovering = false;
        wizard.transform.Translate(Vector2.down * wizard.hoverHeight);
        wizard.shadow.SetActive(false);
        yield return new WaitForSeconds(3f);
        Debug.Log("Nu mai puteti ataca!");
    }
}
