using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wizard_ReadyForFight : StateMachineBehaviour
{
    private Wizard wizard;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard = animator.GetComponent<Wizard>();
        ActivateHoveringMechanic();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    private void ActivateHoveringMechanic()
    {
        wizard.transform.Translate(Vector2.up * wizard.hoverHeight);
        wizard.shadow.SetActive(true);
        wizard.shadow.transform.position = new Vector3(wizard.transform.position.x, -0.5f, wizard.transform.position.z);
        wizard.isHovering = true;
    }
}
