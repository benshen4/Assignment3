using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    //Obtaining audio source
    public AudioSource collectSoundEffect;

    // Reference to the ScoreHolder script to access the totalScore variable.
    public ScoreController scoreController;


    // Start is called before the first frame update
    void Start()
    {
        // Find and assign the ScoreHolder component of the GameObject with the "Player" tag.
        scoreController = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreController>();
        collectSoundEffect = this.GetComponent<AudioSource>();

    }

    // OnTriggerEnter is called when the Collider other enters the trigger collider of this GameObject.
    public void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player".
        if (other.tag == "Player")
        {
            // Add the bonusAmount to the player's total score.

            scoreController.currentScore += 1f;

            //Play a sound effect for pickup

            collectSoundEffect.Play();

            // Log the player's updated score to the console for debugging purposes.

            Debug.Log("Player's current score is: " + scoreController.currentScore);

            //Destroy the coin once it has been collected

            Destroy(gameObject, 0.5f);

        }
    }
}
