using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_IceBreath : StateMachineBehaviour
{
    private Wizard wizard;
    private GameObject player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        wizard = animator.GetComponent<Wizard>();
        player = GameObject.Find("Player");
        GetCloserToGround();
        wizard.isGoingAfterPlayer = true;
        wizard.StartCoroutine(StopChasingPlayer(animator));
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        while (wizard.isGoingAfterPlayer)
        {
            wizard.transform.position = Vector2.MoveTowards(wizard.transform.position, player.transform.position, 3f * Time.deltaTime);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    private void GetCloserToGround()
    {
        wizard.shadow.transform.position = wizard.transform.position + new Vector3(0, -2f, 0);
        wizard.transform.Translate(0, -0.5f, 0);
        wizard.shadow.SetActive(true);
    }

    private IEnumerator StopChasingPlayer(Animator animator)
    {
        yield return new WaitForSeconds(6f);
        wizard.isGoingAfterPlayer = false;
        animator.SetInteger("randomAttack_i", Random.Range(0, 3));
    }
}
