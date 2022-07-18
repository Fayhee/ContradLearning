using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using Object = System.Object;
using Random = UnityEngine.Random;

public class DayData : MonoBehaviour
{

    string url = "https://skylar3.s3.eu-west-2.amazonaws.com/Earth-school/Fish+species.json";
    TheData[] m_Data;
     bool m_DataCaptured;

    public bool DataCaptured
    {
        get => m_DataCaptured;
    }

    void OnEnable()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetData()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log("Error occured with web request");
            }
            else
            {
                m_Data = JsonConvert.DeserializeObject<TheData[]>(webRequest.downloadHandler.text);

                m_DataCaptured = true;
            }
        }
    }

    public string Getaqi(DataUIDisplay.Day day)
    {
        if (m_DataCaptured)
        {
            return m_Data[GetDayName(day)].aqi;
        }
        else
        {
            return "Nothing";
        }
    }

    

	
     public int? GetNo2(DataUIDisplay.Day day)
    {
        if (m_DataCaptured)
        {
            return m_Data[GetDayName(day)].Protein;
        }
        else
        {
            return 0;
        }
    }


    public int GetDayName(DataUIDisplay.Day dayName)
    {
        return (int) dayName;
    }
}



public class TheData
{
    
public string aqi;
public int? N02;
public int? Protein;

}
