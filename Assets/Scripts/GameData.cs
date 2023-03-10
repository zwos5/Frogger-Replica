using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;

    public static float CarSpawnSpeed;
    public Slider CarSpawn;
    public Text CarSpawnTxt;

    public static float CarSpeed;
    public Slider CarSpeedSlider;
    public Text SpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName() 
    {
        PlayerName = showPlayerName.text;  
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;

    }

    public void SpawnCar()
    {
        CarSpawnSpeed = SliderValues.CarSpawn;
    }

    public void SpeedCar()
    {
        CarSpeed = SliderValues.CarSpeed;
    }
}
