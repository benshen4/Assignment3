using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{

    //References needed for script
    public HealthManager healthManager;
    public ScoreController scoreController;
    public ForestFire3D forestFire;

    //Variables for the text displayed on the UI
    public TMP_Text healthText;
    public TMP_Text scoreText;
    public TMP_Text difficultyText;



    // Update is called once per frame
    void Update()
    {
        //Displays the current values for the score, health and difficulty 
        //Only if a difficulty has been selected
        if (forestFire.difficultySelected == true)
        {

            healthText.text = healthManager.currentHealth.ToString();
            scoreText.text = scoreController.currentScore.ToString() + (" / ") + forestFire.coinModifier;
            difficultyText.text = forestFire.difficulty.ToString();
        }
        //If no difficulty has been selected, text variables are instead set to N/A
        else
        {
            healthText.text = ("N/A");
            scoreText.text = ("N/A");
            difficultyText.text = ("N/A");
        }
    }
}
