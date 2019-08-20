using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    player1,
    player2,
}

public class PaddleImput : MonoBehaviour
{
    public PlayerController playerSetting; 
    public float speed;
    public float clampValue;
    public string axisName;

    private void Start()
    {
        if (playerSetting == PlayerController.player1)
        {
            axisName = "player1";
        }
        if (playerSetting == PlayerController.player2)
        {
            axisName = "player2";
        }
    }


    // Update is called once per frame
    void Update()
    { 
          
        MovePaddle(Input.GetAxis(axisName));

    }

    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = 
            gameObject.transform.position + new Vector3(amountToMove * speed, 0, 0);
        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -44, 44);

        gameObject.transform.position = clampedGameObjectPosition;

       
    }


}
