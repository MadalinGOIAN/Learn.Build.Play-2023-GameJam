using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public bool isHovering;
    public float hoverHeight;
    public GameObject shadow;
    public WizardMoveSet move;
}

public enum WizardMoveSet
{
    Idle, GetOnGorundLevel, Tornadoes, IceBreath
}
