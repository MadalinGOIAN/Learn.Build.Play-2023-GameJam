using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityManager : MonoBehaviour
{
    private bool fightHasStarted = false;
    private Wizard wizard;

    // Start is called before the first frame update
    void Start()
    {
        wizard = gameObject.GetComponent<Wizard>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!fightHasStarted)
        {
            Debug.Log("The fight has been triggered");

            fightHasStarted = true;
            ActivateHoveringMechanic();
        }
    }

    private void ActivateHoveringMechanic()
    {
        transform.Translate(Vector2.up * wizard.hoverHeight);
        wizard.shadow.SetActive(true);
        wizard.shadow.transform.position = new Vector3(transform.position.x, -0.5f, transform.position.z);
        wizard.isHovering = true;
    }
}
