using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI cogtText;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
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
        cogtText.text = "" + cog;
    }
}
