﻿using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + "."; 
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + "."; 
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + "."; 
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount.ToString("F0");

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        halfLapTrig.SetActive(true);
        lapCompleteTrig.SetActive(false); 
    }
}