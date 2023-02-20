using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
    public Animation open_1;



    // Update is called once per frame
    public void OnTriggerEnter()
    {
        open_1.Play();
    }
}