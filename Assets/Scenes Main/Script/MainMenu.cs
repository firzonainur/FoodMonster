using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GameObject set, setUI;

    public void Awake()
    {
        setUI = GameObject.Find("SettingUI");
        setUI.SetActive(false);
        set = GameObject.Find("Fade");
        set.SetActive(false);
    }

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

    public void Setting()
    {
        setUI.SetActive(true);
        set.SetActive(true);
    }
}
