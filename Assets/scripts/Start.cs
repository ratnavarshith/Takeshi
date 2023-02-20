using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas_1;
    public GameObject canvas_2;
    // Update is called once per frame
   public void Update()
    {
        if (canvas_1.activeSelf)
        {
            canvas_2.SetActive(true);
            canvas_1.SetActive(false);
        }
        else 
        {
            canvas_1.SetActive(true);
            canvas_2.SetActive(false);
        } 
    }
}
