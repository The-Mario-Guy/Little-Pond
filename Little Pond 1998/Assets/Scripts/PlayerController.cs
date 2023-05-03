using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float _moveSpeed = 20;
    public Rigidbody _rigidBody;
     

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed*Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
    
}
