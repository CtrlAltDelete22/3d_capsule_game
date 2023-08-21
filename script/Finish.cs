using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] AudioSource FinishAudio;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player") 
        {
            FinishAudio.Play();
            Invoke("NextLevel", 1.3f);
        }
    }
    private void NextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
