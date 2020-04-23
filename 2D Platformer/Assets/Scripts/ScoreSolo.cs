using UnityEngine;
using System.Collections;

public class ScoreSolo : MonoBehaviour {
    public SimplePlatformController controll;
    private int count11;
    public int hiScoreCount;
    public GUIText highscoretext;
    public bool scoreInc;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (controll != null)
            count11 = controll.count1;
        hiScoreCount = count11;
        highscoretext.text = "High score: " + count11.ToString();
    }
}
