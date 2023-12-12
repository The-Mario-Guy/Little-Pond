using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI cogtText;

    [SerializeField] private int _cogs;
    private static GameManager _instance;
    
    private void Start()
    {
        _cogs = 0;
    }

    private void Update()
    {
        UpdateCogText(_cogs);
     
    }



    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                
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

    public void AddCoins()
    {
        _cogs++;
    }
    public void UpdateCogText(int cog)
    {
        cogtText.text = "" + cog;
    }


}
