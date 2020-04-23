using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {


    public int scoreValue;
    private SimplePlatformController simplePlatformController;
    private Score score;
    public int count1;
   
    void Awake()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
    }
    // Use this for initialization
    void Start()
    {

        GameObject simplePlatformControllerObject = GameObject.FindWithTag ("Player");
        if (simplePlatformControllerObject != null)
        {
            simplePlatformController = simplePlatformControllerObject.GetComponent <SimplePlatformController>();
        }
    
	    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(CircleCollider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count1 = count1 + 1;
            
        }
    }
}