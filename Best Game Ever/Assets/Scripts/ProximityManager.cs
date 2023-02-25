using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityManager : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("The fight has been triggered");
       animator.SetBool("hasFightStarted_b", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("The fight has been stopped");
        animator.SetBool("hasFightStarted_b", false);
    }
}
