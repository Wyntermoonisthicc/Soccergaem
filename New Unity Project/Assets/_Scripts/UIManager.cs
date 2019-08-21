using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager: MonoBehaviour
{

    public Text blueScore;
    public Text redScore;
    // Start is called before the first frame update
    void Start()
    {
        blueScore.text = "0";
        redScore.text = "0";
    }

    public void UpdateScore(int p1score, int p2score)
    {
        blueScore.text = p1score.ToString();
        redScore.text = p2score.ToString();
    }


    

}
