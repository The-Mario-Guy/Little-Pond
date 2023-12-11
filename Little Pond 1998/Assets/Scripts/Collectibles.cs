using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;

public class Collectibles : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;

    private float yAxis;
    //public AudioSource collectedSFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.PlayOneShot(source.clip);
            StartCoroutine(collected());
        }
        else
        {
            yAxis = 0f;
        }
    }
    IEnumerator collected()
    {
       GameManager.Instance.AddCoins();
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
        source = GetComponent<AudioSource>();
    }
}
