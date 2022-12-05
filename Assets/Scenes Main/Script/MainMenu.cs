using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject set, setUI;

    private void Awake()
    {
        set.SetActive(false);
        setUI.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("keluar");
    }

    public void Stage()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Stage");
    }

    public void Adventure()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Adventure Mode");
    }

    public void Setting()
    {
        setUI.SetActive(true);
        set.SetActive(true);
    }
}
