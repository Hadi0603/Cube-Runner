using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "FinishLine")
        {
            gameController.LevelComplete();
            playerScript.enabled = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            audioSource1.Play();
            gameController.GameOver();
            playerScript.enabled = false;
        }
        
    }
}