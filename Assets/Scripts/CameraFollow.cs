using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public static CameraFollow cFollow;

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public float MidX;
    public float MidY;
    public float MidZ;
    public Transform target1;
    public Transform target2;
    public Vector3 Midpoint;
    public Vector3 distance;
    public float camDistance;
    public float CamOffset;
    public GameObject cameraKill;
    public GameObject sure;
    public GameObject def;
    
    void Start()
    {
        camDistance = 215;
        sure.gameObject.SetActive(false);
        def.gameObject.SetActive(true);
        
    }

    void Update()
    {
        distance = target1.position - target2.position;
    
        if (camDistance <= 215f)
            camDistance = 215f;
    
        if (distance.x > 15.0f)
        {
           CamOffset = distance.x * 0.3f;
            if (CamOffset >= 8.5f)
                CamOffset = 8.5f;
        }
        else if (distance.x < 14.0f)
        {
            CamOffset = distance.x * 0.3f;
        }
       
        MidX = (target2.position.x + target1.position.x) / 2;
        MidY = (target2.position.y + target1.position.y) / 2;
      
        Midpoint = new Vector3(MidX, MidY);
        if (target1)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(Midpoint);
            Vector3 delta = Midpoint - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, camDistance + CamOffset));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
       
    }

    public void OnTriggerEnter2D(Collider2D other)

    {

       
    }
}
