using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishInfoLoader : MonoBehaviour
{
    public Transform FishInfo;
    public void OpenCanvas()
    {
        if (FishInfo.gameObject.activeInHierarchy == false)
        {
            FishInfo.gameObject.SetActive(true);

        }
        else
        {
            FishInfo.gameObject.SetActive(false);

        }
    }
}
