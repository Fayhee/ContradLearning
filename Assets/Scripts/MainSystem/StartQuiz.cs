using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    public GameObject GameMenu; 
    public GameObject MainMenu;
    public GameObject Bars;
    public GameObject UI;
    public GameObject DropDown;

    public GameObject DataCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StartQuiz2()
    {
        MainMenu.SetActive(true);
        

        UI.SetActive(false);
        DropDown.SetActive(false);
        Bars.SetActive(false);

        GameObject.Destroy(DataCanvas);


    }

    
}
