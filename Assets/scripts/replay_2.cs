using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay_2 : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {

            SceneManager.LoadScene(3);
        }
    }
}
