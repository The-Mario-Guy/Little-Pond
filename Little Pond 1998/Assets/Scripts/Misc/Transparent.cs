using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
    //public Renderer _Ren;
    public float alpha = 1f;
    public GameObject currentGameObject;
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;
        trigger = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alpha);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject)
        {
            alpha = 0.0f;
        }
        else
        {
            alpha = 1f;
        }
            
    }
}
