using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Variable to store the player's maximum health.
    public float playerMaxHealth;

    // Variable to store the player's current health.
    public float playerCurrentHealth;

    // Reference to the TextMeshPro component for displaying health information.
    public TMP_Text healthText;

    // Reference to the Slider UI element for visualizing health.
    public Slider healthSlider;

    // Reference to the Slider's fill image for changing its color.
    public Image healthSliderFill;

    // Start is called before the first frame update
    void Start()
    {
        // Check if the healthSlider is assigned. If not, log an error message.
        if (healthSlider == null)
        {
            Debug.LogError("Health Slider not set!");
        }

        // Set the maximum value of the healthSlider to playerMaxHealth.
        healthSlider.maxValue = playerMaxHealth;

        // Initialize playerCurrentHealth to playerMaxHealth.
        playerCurrentHealth = playerMaxHealth;
        Debug.Log("The starting health of the player is: " + playerCurrentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Update the displayed health text with the player's current health.
        healthText.text = "Health: " + playerCurrentHealth;

        // Update the healthSlider's value to represent the player's current health.
        healthSlider.value = playerCurrentHealth;

        // Adjust the color of health text and slider fill based on player's health percentage.
        if (playerCurrentHealth >= (playerMaxHealth / 100) * 50)
        {
            healthText.color = Color.green;
            healthSliderFill.color = Color.green;
        }
        else if (playerCurrentHealth >= (playerMaxHealth / 100) * 30 && playerCurrentHealth <= (playerMaxHealth / 100) * 50)
        {
            healthText.color = Color.yellow;
            healthSliderFill.color = Color.yellow;
        }
        else if (playerCurrentHealth >= (playerMaxHealth / 100) * 0 && playerCurrentHealth <= (playerMaxHealth / 100) * 30)
        {
            healthText.color = Color.red;
            healthSliderFill.color = Color.red;
        }

        // Check if the player's health is zero or less. If so, log an error message.
        if (playerCurrentHealth <= 0)
        {
            Debug.LogError("The player has reached " + playerCurrentHealth + " health and has died!");
        }
    }
}
