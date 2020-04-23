using UnityEngine;
using System.Collections;

public class DistanceCS : MonoBehaviour
{

    float runTime;
    

    void Start()
    {
        PlayerPrefs.GetFloat("runTime", runTime);
    }

    void OnDestroy()
    { // Set when my player dies
        var savedTime = PlayerPrefs.GetFloat("runTime");
        PlayerPrefs.SetFloat("runTime", savedTime + Time.timeSinceLevelLoad);

        Debug.Log(PlayerPrefs.GetFloat("runTime"));
    }

    void OnGUI()
    {
        GetComponent<GUIText>().text = "Time: " + Time.timeSinceLevelLoad.ToString("F2") + "\nTotal Time: " + PlayerPrefs.GetFloat("runTime");
        //+ "\nTotal Time: " + runTime + Time.timeSinceLevelLoad.ToString ("F2");
    }
}