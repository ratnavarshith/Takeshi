using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject canvas;
    public GameObject character;
    public GameObject Camera;
    public GameObject scr;
    
    // Update is called once per frame
    void OnTriggerEnter()
    {
        
        canvas.SetActive(true);
        character.SetActive(false);
        Camera.SetActive(true);
        scr.SetActive(true);
    }
}
