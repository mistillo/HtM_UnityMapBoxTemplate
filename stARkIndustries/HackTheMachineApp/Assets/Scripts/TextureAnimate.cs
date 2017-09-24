using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimate : MonoBehaviour
{
    float xOffset=0f;
    float yOffset=0f;

    float framesPerSecond = 5.0f;

    float currentTime = 0;

    Vector2 offset;

    private Renderer r=null;

    private void Start()
    {
        offset = new Vector2(xOffset, yOffset);
    }

    void Update()
    {
        
        if(Time.time>currentTime+.13f)
        {
            if(r==null)
            {
                try
                {
                    r = GetComponent<Renderer>();
                }
                catch { }
            }
            else
            { 
                offset.x = offset.x - .05f;
                r.material.SetTextureOffset("_MainTex", offset);
                currentTime = Time.time;
            }
 
        }

    }
}
