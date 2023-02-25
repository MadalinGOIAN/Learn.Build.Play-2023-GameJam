using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public enum MoveSet
    {
        GetOnGroundLevel,
        Tornadoes,
        IceBreath
    }

    public bool isHovering;
    public float hoverHeight;
    public float waitTime;
    public GameObject shadow;
    public MoveSet[] moveSet = { MoveSet.GetOnGroundLevel, MoveSet.Tornadoes, MoveSet.IceBreath };

    public IEnumerator GetOnGroundLevel()
    {
        Debug.Log("Started GetOnGroundLevel move");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Ended GetOnGroundLevel move");
    }

    public IEnumerator Tornadoes()
    {
        Debug.Log("Started Tornadoes move");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Ended Tornadoes move");
    }

    public IEnumerator IceBreath()
    {
        Debug.Log("Started IceBreath move");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Ended IceBreath move");
    }
}
