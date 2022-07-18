using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreachQuiz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainCanvas;
    public GameObject VideoPlayer;

    private void OnEnable()
    {
        MainCanvas.SetActive(true);
        VideoPlayer.SetActive(false);

    }

}
