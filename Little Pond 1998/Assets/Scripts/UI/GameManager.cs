using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public TextMeshProUGUI cogtText;

    private static GameManager _instance;
    public static GameManager Instance
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
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void UpdateCogText(int cog)
    {
        //cogtText.text = ""+cog;
    }
}
