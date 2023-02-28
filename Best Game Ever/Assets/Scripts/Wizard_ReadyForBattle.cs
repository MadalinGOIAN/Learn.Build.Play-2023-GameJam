using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wizard_ReadyForBattle : StateMachineBehaviour
{
    private Wizard wizard;
    private float shadowOffset = -0.5f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard = animator.GetComponent<Wizard>();
        ActivateHoveringMechanic();
        wizard.StartCoroutine(StartRandomAttack(animator));
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
        wizard.shadow.transform.position = new Vector3(wizard.transform.position.x,
                                                       wizard.transform.position.y - wizard.hoverHeight + shadowOffset,
                                                       wizard.transform.position.z);
        wizard.shadow.SetActive(true);
        wizard.isHovering = true;
    }

    private IEnumerator StartRandomAttack(Animator animator)
    {
        Debug.Log("Dupa " + wizard.waitTime + "sec vom alege un atac random");
        yield return new WaitForSeconds(wizard.waitTime);
        Debug.Log("Timpul a trecut");
        animator.SetInteger("randomAttack_i", Random.Range(0, 2));
    }
}
