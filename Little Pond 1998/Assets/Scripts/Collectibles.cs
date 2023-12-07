using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;

public class Collectibles : MonoBehaviour
{
    private float yAxis;
    public AudioSource collectedSFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectedSFX.Play();
            MainPlayerController.Instance.AddCoins();
            StartCoroutine(collected());
        }
        else
        {
            yAxis = 0f;
        }
    }
    IEnumerator collected()
    {
        
        yAxis = 0.1f;
        yield return new WaitForSeconds(0.2f);
        yAxis = 0.2f;
        yield return new WaitForSeconds(0.1f);
        yAxis = 0.4f;
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);

    }
    private void Update()
    {
        transform.Translate(0, yAxis, 0);
    }
    private void Start()
    {
        collectedSFX = GetComponent<AudioSource>();
    }
}
