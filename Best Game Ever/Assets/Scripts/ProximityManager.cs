using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Wizard;

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
            StartFight();
        }
    }

    private void StartFight()
    {
        ActivateHoveringMechanic();

        // TODO: Trb schimbata conditia a.i. lupta sa se termine daca bossu sau playeru ramane fara viata
        for (int i = 0; i < 10; i++)
        {
            _ = new WaitForSeconds(2f);
            ChooseRandomMove();
        }
    }

    private void ActivateHoveringMechanic()
    {
        transform.Translate(Vector2.up * wizard.hoverHeight);
        wizard.shadow.SetActive(true);
        wizard.shadow.transform.position = new Vector3(transform.position.x, -0.5f, transform.position.z);
        wizard.isHovering = true;
    }

    private void ChooseRandomMove()
    {
        int randomMoveIndex = UnityEngine.Random.Range(0, wizard.moveSet.Length);
        MoveSet chosenMove = wizard.moveSet[randomMoveIndex];

        switch (chosenMove)
        {
            case MoveSet.GetOnGroundLevel:
                StartCoroutine(wizard.GetOnGroundLevel());
                break;

            case MoveSet.Tornadoes:
                StartCoroutine(wizard.Tornadoes());
                break;

            case MoveSet.IceBreath:
                StartCoroutine(wizard.IceBreath());
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
