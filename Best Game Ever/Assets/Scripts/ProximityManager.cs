using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityManager : MonoBehaviour
{
    public bool fightHasStarted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!fightHasStarted)
        {
            Debug.Log("The fight has been triggered");
            fightHasStarted = true;
        }
    }
}
