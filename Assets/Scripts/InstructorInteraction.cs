using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using NRKernal;
public class InstructorInteraction : MonoBehaviour
{

    public GameObject instructor;
    public GameObject buttonCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get controller rotation, and set the value to the instructor transform
        transform.rotation = NRInput.GetRotation();
        
    }

    public void ShowInstructor()
    {
        instructor.SetActive(true);
        buttonCanvas.SetActive(true);
    }

    public void HideInstructor()
    {
        instructor.SetActive(true);
        buttonCanvas.SetActive(true);
    }
}
