using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemySc : MonoBehaviour
{
    bool dead = false;
    [SerializeField] AudioSource DeathAudio;
    private void Update()
    {
        if(transform.position.y < -1f && !dead) 
        {
            Die();

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Die();
        }
    }
    private void Die() 
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement1>().enabled = false;
        dead = true;
        Invoke(nameof(restart), 1.3f);
        DeathAudio.Play();
    }
    private void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
