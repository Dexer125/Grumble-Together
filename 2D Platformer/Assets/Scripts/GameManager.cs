using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Transform platformGenerator;
    private Vector3 platformStart;

    public GameObject player;
    private Vector3 playerStart;

    private PlatformDestroy[] platformList;



    // Use this for initialization
    void Start()
    {
        platformStart = platformGenerator.position;
        platformStart = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

     public IEnumerator RestartGameCo()
     {
         player.gameObject.SetActive(false);
        yield return new WaitForSeconds(0f);
        platformList = FindObjectsOfType<PlatformDestroy>();

        for (int i = 0; i < platformList.Length; i++) 
          {
            platformList[i].gameObject.SetActive(false);
        }
        player.transform.position = playerStart;
       platformGenerator.position = platformStart;
      player.gameObject.SetActive(true);
}
}
