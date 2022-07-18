using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class BioFuel : MonoBehaviour
{
    public GameObject trash;
    public GameObject wood;
    public GameObject weed;


    public TMP_Text info;
    public GameObject hMI;
    public GameObject hUD;
    public GameObject metaDataButton;
    public GameObject sceneButton;

    private bool trashIsActive;
    private bool woodIsActive;
    private bool weedIsActive;
    // Start is called before the first frame update
    void Start()
    {
        trashIsActive = trash.activeSelf;
        woodIsActive = wood.activeSelf;
        weedIsActive = weed.activeSelf;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((trash.activeSelf == false) && (wood.activeSelf == false) && (weed.activeSelf == false))
        {
            info.text = "Congrats!!!";
            hMI.SetActive(true);
            sceneButton.SetActive(true);
            metaDataButton.SetActive(false);
            hUD.SetActive(false);
            
            Debug.Log("BioFuel");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            hMI.SetActive(true);
        }
    }

    public void NFTScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void closeInfo()
    {
        hMI.SetActive(false);
    }
}
