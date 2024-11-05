using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    string playerName = "";
    int health = 100;
    static int playerCount = 0;


    void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount += 1;
    }


    void Heal(int amount)
    {
        health += amount;
        Debug.Log(health);

    }

    void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
        }

    }

    static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }



}
