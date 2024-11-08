using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player firstPlayer = new Player();
        Player secoundPlayer = new Player();

        firstPlayer.InitializePlayer("Samy", 100);
        secoundPlayer.InitializePlayer("Ola", 100);


        firstPlayer.Heal(1);
        firstPlayer.Heal(true);

        secoundPlayer.Heal(3);
        secoundPlayer.Heal(false);

        Player.ShowPlayerCount();





    }

}
