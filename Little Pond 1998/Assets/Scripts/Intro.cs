using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer _Intro;
    public VideoPlayer Vid;
    void Start()
    {
        _Intro = GetComponent<MeshRenderer>();
        Vid = GetComponent<VideoPlayer>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene(1);
        //_Intro.enabled = false;
        Vid.enabled = false;
    }
}
