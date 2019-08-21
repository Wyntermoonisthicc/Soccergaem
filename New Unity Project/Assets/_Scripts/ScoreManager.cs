using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int blue;
    public int red;
    private UIManager uiMan;

    private void Start()
    {
        uiMan = GetComponent<UIManager>();
    }
    public void blueScored()
    {
        blue++;
        uiMan.UpdateScore(blue, red);
        
    }

    public void redScored()
    {
        red++;
        uiMan.UpdateScore(blue, red);
       

    }

}
