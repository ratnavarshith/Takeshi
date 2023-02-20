using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    
    // Update is called once per frame
    public void Replay()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene(0);
        
    }
}
