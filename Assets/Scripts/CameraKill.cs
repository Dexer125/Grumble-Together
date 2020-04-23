using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraKill : MonoBehaviour {


    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player1"))
        {
            SceneManager.LoadScene(3);
          

        }
        else if (other.gameObject.CompareTag("Player2"))

        {
            SceneManager.LoadScene(4);


        }
    }
}
