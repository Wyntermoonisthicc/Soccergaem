using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager instance;
    private List<int> potentialAngles = new List<int> { 45, 90, 180, 270 };

    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        InstantiateBall();
    }

    

    public void InstantiateBall()
    {
        int Index = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(0, potentialAngles[Index], 0));
    }
       


}
