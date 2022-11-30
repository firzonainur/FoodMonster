using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, 
{
    public VirtualButtonBehaviour vbBtnObj;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj.RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
