using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutsceneTimer : MonoBehaviour
{
    public int sceneNumber;
    //public float cutsceneLength;
    bool loadingStarted = false;
   public float secondsLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadLevel(secondsLeft));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;

        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);
        SceneManager.LoadScene(sceneNumber);
    }
}
