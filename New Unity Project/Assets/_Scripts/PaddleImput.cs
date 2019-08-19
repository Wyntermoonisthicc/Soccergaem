using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleImput : MonoBehaviour
{
    public float speed;
    public float clampValue;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
          
        MovePaddle(Input.GetAxis("Horizontal"));

    }

    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = 
            gameObject.transform.position + new Vector3(amountToMove * speed, 0, 0);
        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -44, 44);

        gameObject.transform.position = clampedGameObjectPosition;

       


       
    }


}
