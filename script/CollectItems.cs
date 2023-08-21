using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectItems : MonoBehaviour
{
    [SerializeField] Text Coinstext;
    [SerializeField] AudioSource CollectAudio;
    private int coins = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
            coins++;
            Coinstext.text = "Coins: " + coins;
            CollectAudio.Play();
        }
    }
}
