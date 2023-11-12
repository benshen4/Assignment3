using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HealthManager : MonoBehaviour
{

    //Declaring needed variables
    public float maxHealth;
    public float currentHealth;
    public bool healthInitialised;
    //Refernce to the main forestfire script
    public ForestFire3D forestFire;


    // Start is called before the first frame update
    void Start()
    {
        //Initialising health. Set to 1 (>0) to ensure the player doesn not meet the death condition (0 health) before unpausing
        currentHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Statement to initialise the player's health. This is dependant on the difficulty chosen.
        //code will not be executed until a difficulty has been selected.
        //healthInitialised set to true after loop, so code will only run once.
        if (healthInitialised == false && forestFire.difficultySelected == true)
        {
            maxHealth = 100 - forestFire.healthModifier;
            currentHealth = maxHealth;
            healthInitialised = true;
        }


        //Code that checks if the player's health has dropped to or below zero.
        //Player will be teleported if this occurs as the player has died.
        if (currentHealth <= 0)
        {
            Debug.LogError("The player has reached " + currentHealth + "and has died");
            TeleportDeath();
            forestFire.hasTeleported = true;
        }
    }


    //Void which teleports the player to the 'teleportSpot' when called upon
    //Current health is set to 1 so the code is not looped
    //Can also avoid this by having a bool set to true after death
    public void TeleportDeath()
    {
        forestFire.xrRig.transform.position = forestFire.teleportSpot.position;
        currentHealth = 1;
        forestFire.hasTeleported = true;
    }


}
