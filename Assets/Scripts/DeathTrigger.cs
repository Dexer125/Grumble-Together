using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathTrigger : MonoBehaviour {

   
    public GUIText score;

    public Transform player;

    private int playerCoins ;
    

	void Update () {
        if (transform.position.y <= -200)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

   // void OnTriggerEnter2D (Collider2D other)
   // {
    //    if (other.gameObject.CompareTag("Player"))
     //   {
            


     //      Application.LoadLevel(Application.loadedLevel);

            

     //   }
   // }

   
}
