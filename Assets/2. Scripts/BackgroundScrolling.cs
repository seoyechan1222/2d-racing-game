using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    Renderer rend;
    public float scrollspeed = 10f;
    public bool xAxis;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollspeed;
        if (!xAxis)
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        }
        else
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
    }
    
}
