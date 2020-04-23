using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RestartLevel()
    {


        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {


        SceneManager.LoadScene(0);
    }
}


