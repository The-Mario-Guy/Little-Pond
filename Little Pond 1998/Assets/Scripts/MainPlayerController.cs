using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float _moveSpeed = 20;
    public Rigidbody _rigidBody;

    [SerializeField] private int _cogs;
    private static MainPlayerController _instance;
    
    void Start()
    {
        _cogs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //UIManager.Instance.UpdateCogText(_cogs);
        Movement();
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);

    }
    public static MainPlayerController Instance
    {
        get
        {
            if (_instance == null )
            {
                Debug.LogError("Player is Null");
            }
            return _instance;
        }

    }
    private void Awake()
    {
          _instance = this;
          
        
    }
    public void AddCoins()
    {
        _cogs++;
    }

}
