using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualMGR : MonoBehaviour
{
    public int Vis;
    void Start()
    {
        Vis = PlayerPrefs.GetInt("res", 0);
        switch (Vis)
        {
            case 1:
                Screen.SetResolution(1280, 720, true);
                break;
            case 2:
                Screen.SetResolution(1920, 1080, true);
                break;
            case 3:
                Screen.SetResolution(2560, 1440, true);
                break;
            case 4:
                Screen.SetResolution(3440, 1440, true);
                break;
            default:
                //keeps it at preset res
                break;
        }
    }
    public void Bttn720()
    {
        Screen.SetResolution(1280, 720, true);
        PlayerPrefs.SetInt("res", 1);
    }
    public void Bttn1080()
    {
        Screen.SetResolution(1920, 1080, true);
        PlayerPrefs.SetInt("res", 2);
    }
    public void Bttn2560()
    {
        Screen.SetResolution(2560, 1440, true);
        PlayerPrefs.SetInt("res", 3);
    }
    public void Bttn3440()
    {
        Screen.SetResolution(3440, 1440, true);
        PlayerPrefs.SetInt("res", 4);
    }
}
