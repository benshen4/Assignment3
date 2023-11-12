using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    //Declaring references and variables
    public HealthManager healthManager;
    public float damageValue;


    // Start is called before the first frame update
    void Start()
    {
        //Assigning components and damage values
        healthManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthManager>();
        damageValue = 25f;  
    }


    public void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player".
        if (other.tag == "Player")
        {
            // Subtract damageValue from the player's current health.
            healthManager.currentHealth -= damageValue;

            // Log the player's current health to the console for debugging.
            Debug.Log("The player's current health is " + healthManager.currentHealth);
        }
    }
}
