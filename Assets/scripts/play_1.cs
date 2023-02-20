using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_1 : MonoBehaviour
{
    public float speed = 2f;
    public MeshRenderer renderer;

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, Time.time * speed);
        renderer.material.mainTextureOffset = offset;
    }
}
