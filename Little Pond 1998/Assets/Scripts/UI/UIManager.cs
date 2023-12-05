using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI cogtText;

    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
           if(_instance == null)
            {
                Debug.Log("UI Manager is null!");
            }
           return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    public void UpdateCogText(int cog)
    {
        cogtText.text = ""+cog;
    }
}
