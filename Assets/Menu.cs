using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject[] ui;
    public GameObject[] textInfo;

    
    public void offUi()
    {
        for (int i = 0; i < ui.Length; i++) ui[i].SetActive(false);
    }

    public void onUi()
    {
        for (int i = 0; i < ui.Length; i++) ui[i].SetActive(true);
    }

    public void onText(int id)
    {
        textInfo[id].SetActive(true);
    }

    public void offText()
    {
        for (int i = 0; i < textInfo.Length; i++) textInfo[i].SetActive(false);
    }
    public void Offgame()
    {
        Application.Quit();
    }
}
