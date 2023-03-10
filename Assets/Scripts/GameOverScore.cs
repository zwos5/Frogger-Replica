using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text UserName;
    public Text EndScore;
    //public string test;
    public void Awake()
    {
        //test = GameData.PlayerName;
        UserName.text = GameData.PlayerName; //test
        EndScore.text = PlayerScore.CurrentScore.ToString();
    }
}
