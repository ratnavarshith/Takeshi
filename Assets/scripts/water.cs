using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public AudioSource sound;
    public GameObject Player;
    // Update is called once per frame
    void Sound()
    {
        if ((Player.transform.position.y) <= 6)
        {
            sound.Play();
        }
    }
}
