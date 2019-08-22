using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        transform.position =  new Vector3(Mathf.PingPong(Time.time, 9), 0, -58);
    }
}
