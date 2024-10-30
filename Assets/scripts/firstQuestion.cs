using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (1 == 1)
        {
            int randomNumber = UnityEngine.Random.Range(1, 21);

            if (randomNumber == 5)
            {
                continue;
            }

            if (randomNumber == 15)
            {
                Debug.Log(randomNumber);
                break;

            }
            Debug.Log(randomNumber);




        }










    }


}
