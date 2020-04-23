using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {
    public GameObject ground;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float distanceBetween;
    private float groundWidth;
    public float distanceBetweenMin;
    public float distanceBetweenMax;
    private float groundHeight;
    public float distanceYmin;
    public float distanceYmax;
    public float distanceHeight;


	
	void Start () {
        groundWidth = ground.GetComponent<BoxCollider2D>().size.x;
        groundHeight = ground.GetComponent<BoxCollider2D>().size.y;

    }
	
	
	void Update () {
        if (transform.position.x < spawnPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            distanceHeight = Random.Range(distanceYmin, distanceYmax);


            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, transform.position.y + groundHeight + distanceHeight , transform.position.z);
            Instantiate(ground, transform.position, transform.rotation);
	}
        else if (transform.position.x < spawnPoint2.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            distanceHeight = Random.Range(distanceYmin, distanceYmax);


            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, transform.position.y + groundHeight + distanceHeight, transform.position.z);
            Instantiate(ground, transform.position, transform.rotation);
        }
    }
}
