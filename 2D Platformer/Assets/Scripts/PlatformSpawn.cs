using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {
    public GameObject ground;
    public Transform spawnPoint;
    public float distanceBetween;
    private float groundWidth;


	// Use this for initialization
	void Start () {
        groundWidth = ground.GetComponent<BoxCollider2D>().size.x;

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < spawnPoint.position.x)
        {


            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(ground, transform.position, transform.rotation);
	}
    }
}
