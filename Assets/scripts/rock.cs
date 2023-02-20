using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation fall;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        fall.Play();
    }
}
