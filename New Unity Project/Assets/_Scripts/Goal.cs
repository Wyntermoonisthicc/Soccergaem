using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public string teamName;
    public ScoreManager sm;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
       BallManager.instance.InstantiateBall();

        if(teamName == "blue")
        {
            sm.blueScored();
        }         
       




        if (teamName == "red")
        {
            sm.redScored();
        }

    }



}
