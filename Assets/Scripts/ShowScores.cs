using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ShowScores : MonoBehaviour
{
    public Text HighScores;
    private int numScores = 10;

    public void ShowTopScores()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[numScores];
        int[] playerScores = new int[numScores];
        int scores_read = 0;

        HighScores.text = ""; 

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream && scores_read < numScores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }

    }
}
