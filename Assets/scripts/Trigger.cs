using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Animator x;

    private void OnTriggerEnter(Collider other)
    {
        x.SetBool("kailash", true);
    }

    private void OnTriggerExit()
    {
        x.SetBool("kailash", false);
    }
}

