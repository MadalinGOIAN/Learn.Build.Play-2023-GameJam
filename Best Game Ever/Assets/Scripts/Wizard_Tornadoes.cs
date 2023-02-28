using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_Tornadoes : StateMachineBehaviour
{
    private Wizard wizard;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard = animator.GetComponent<Wizard>();
        wizard.StartCoroutine(Tornadoes(animator));
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    private IEnumerator Tornadoes(Animator animator)
    {
        var tornado1 = Instantiate(wizard.tornado, wizard.transform.position + new Vector3(0, 1f, 0), wizard.tornado.transform.rotation);
        var tornado2 = Instantiate(wizard.tornado, wizard.transform.position + new Vector3(0, -1f, 0), wizard.tornado.transform.rotation);
        Destroy(tornado1, 5f);
        Destroy(tornado2, 5f);
        yield return new WaitForSeconds(5f);
        animator.SetInteger("randomAttack_i", 0);
    }
}
