using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScrpt : MonoBehaviour
{
    [SerializeField] private GameObject set, setUI, ms, msoff, gtr, gtroff;

    public void Back()
    {
        setUI.SetActive(false);
        set.SetActive(false);
    }

    public void MusiktoOn()
    {    
        ms.SetActive(true);
        msoff.SetActive(false);
    }
    
    public void MusiktoOff()
    {
        msoff.SetActive(true);
        ms.SetActive(false);
    }

    public void GetartoOn()
    {
        gtr.SetActive(true);
        gtroff.SetActive(false);
    }

    public void GetartoOff()
    {
        gtroff.SetActive(true);
        gtr.SetActive(false);
    }
}
