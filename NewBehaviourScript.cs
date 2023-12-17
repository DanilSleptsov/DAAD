using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 2.5f;

    void GetOnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;

    }

    void OnTriggerExit(Collider other)
    {

        other.GetComponent<Jump>().jumpStrength /= jumpFactor;

    }
}