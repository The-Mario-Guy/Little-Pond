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
    public Texture[] downTextures;
    public Texture[] rightTextures;
    public Texture[] leftTextures;
    public int walkingDownTexture;
    public int walkingRightTexture;
    public int walkingLeftTexture;
    private readonly float delayBetweenInputs = 0.1f;
    private float t;
     

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //Animation();
        if(Input.GetKey (KeyCode.DownArrow) && t <= 0)
    {
        walkingDownTexture++;
        walkingDownTexture %= downTextures.Length;
        GetComponent<Renderer>().material.mainTexture = downTextures[walkingDownTexture];
        t = delayBetweenInputs;
    }
    //t -= Time.deltaTime;
    //Left arrow will call for right sprites
        if(Input.GetKey (KeyCode.LeftArrow) && t <= 0)
    {
        walkingRightTexture++;
        walkingRightTexture %= rightTextures.Length;
        GetComponent<Renderer>().material.mainTexture = rightTextures[walkingRightTexture];
        t = delayBetweenInputs;
    }
    //t -= Time.deltaTime;
     if(Input.GetKey (KeyCode.RightArrow) && t <= 0)
    {
        walkingLeftTexture++;
        walkingLeftTexture %= leftTextures.Length;
        GetComponent<Renderer>().material.mainTexture = leftTextures[walkingLeftTexture];
        t = delayBetweenInputs;
    }
    t -= Time.deltaTime;
    }
    
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed*Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
        
    }
    
}
