using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_back : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            character.SetActive(false);
            SceneManager.LoadScene(2);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
