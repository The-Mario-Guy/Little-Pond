using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTransition : MonoBehaviour
{
    public int sceneNumber;
    public bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && inTrigger)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(sceneNumber);
            inTrigger = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

}
