using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("keluar");
    }

    public void Stage()
    {
        Debug.Log("Stage");
    }

    public void Adventure()
    {
        Debug.Log("Adventure Mode");
    }
}
