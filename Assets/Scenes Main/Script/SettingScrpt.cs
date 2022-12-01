using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScrpt : MonoBehaviour
{
    GameObject set, setUI;

    public void Awake()
    {
        setUI = GameObject.Find("SettingUI");
        set = GameObject.Find("Fade");
    }

    public void Back()
    {
        setUI.SetActive(false);
        set.SetActive(false);
    }
}
