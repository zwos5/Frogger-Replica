using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValues : MonoBehaviour
{
    public Slider CarSpawnSlider;
    public Text CarSpawnSliderText;

    public Slider CarSpeedSlider;
    public Text CarSpeedSliderText;

    public static float CarSpawn;
    public static float CarSpeed;

    // Update is called once per frame
    void Update()
    {
        CarSpawn = CarSpawnSlider.value;
        CarSpawnSliderText.text = CarSpawn.ToString("f2");

        CarSpeed = CarSpeedSlider.value;
        CarSpeedSliderText.text = CarSpeed.ToString("f0");
    }
}
