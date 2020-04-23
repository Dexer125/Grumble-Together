using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float speed = 0.5f;

   


    public void Update () {
        Vector2 offset = new Vector2(Time.time * speed, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }

    
}

