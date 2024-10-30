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



        string[] myArr = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int count = 0;
        string word = "";
        while (count < 7)
        {
            int randomIndex = UnityEngine.Random.Range(0, myArr.Length);

            word += myArr[randomIndex] + " ";
            count++;




        }

        Debug.Log(word);







    }


}
