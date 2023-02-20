using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject canvas_1;
    public GameObject Super;
    public GameObject camera;
    public GameObject Canvas_of;
    public GameObject controller;
    public AudioSource sound;
    void OnTriggerEnter()
    {
        canvas_1.SetActive(true);
        Super.SetActive(false);
        camera.SetActive(true);
        Canvas_of.SetActive(false);
        controller.SetActive(true);
        sound.Play(); 

    }
}
