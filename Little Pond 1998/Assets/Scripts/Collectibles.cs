using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MainPlayerController.Instance.AddCoins();
            Destroy(this.gameObject);
        }
    }
}
