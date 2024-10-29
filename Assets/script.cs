using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLives = 3;

        while (playerLives > 0)
        {
            if (playerLives == 3)
            {
                Debug.Log("Many lives");

            }

            if (playerLives == 1)
            {
                Debug.Log("The last life!");
                Debug.Log("edit my code");

            }
            playerLives--;



        }
        Debug.Log("Game Over!");

    }


}
