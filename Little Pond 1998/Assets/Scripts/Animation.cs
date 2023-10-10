using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Texture[] framesTextures;
    public int frames;
    private readonly float delayBetweenInputs = 0.1f;
    private float t;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animationStuff();
       
    }


    void animationStuff()
    {

        {
            t = delayBetweenInputs;
            frames++;
            frames %= framesTextures.Length;
            GetComponent<Renderer>().material.mainTexture = framesTextures[frames];
        }
        


    }
}
