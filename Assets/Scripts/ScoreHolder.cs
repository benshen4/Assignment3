using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    // Variable to store the player's total score.
    public float totalScore;

    // Reference to the TextMeshPro component for displaying the score.
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // Update the displayed score text with the player's total score, converting it to a string.
        scoreText.text = totalScore.ToString();
    }
}
