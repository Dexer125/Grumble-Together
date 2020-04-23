using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathTrigger : MonoBehaviour {

    public GameManager gameManager;
    public GUIText score;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.RestartGame();
            score.text = "Count: " + 0;


            //Application.LoadLevel(Application.loadedLevel);
        }
    }

   
}
