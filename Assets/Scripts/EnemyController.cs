using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   

    //Referencing the other scripts needed
    public HealthManager healthManager;
    public ForestFire3D forestFire;
    public ScoreController scoreController;

    //Declaring variables for the enemy
    public float damageValue;
    public float chaseSpeed;
    public float chaseMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the tag "Player" and get the PlayerHealth component.
        healthManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthManager>();

        //Assigning damage value
        damageValue = 10f;
    }

 
    public void OnTriggerEnter(Collider other)
    {
    
        //If skeleton makes contact with the player then deal appropriate damage

        if (other.tag == "Player")
        {
           
            healthManager.currentHealth -= damageValue;
            Debug.Log("The player's current health is " + healthManager.currentHealth);
        }

    }


    private void Update()
    {

        //Increasing the chase speed by 0.1 per coin collected
        chaseMultiplier = scoreController.currentScore / 10f;
        chaseSpeed = 1 + chaseMultiplier;
        //Code to turn the skeleton asset to the player at all times
        transform.LookAt(forestFire.xrRig.transform.position);


        //Move the skeleton towards the player, at speed 'chaseSpeed', so long as the game is running and the player hasn't won/lost
        if (forestFire.gameRunning == true && forestFire.hasTeleported == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, forestFire.xrRig.transform.position, chaseSpeed * Time.deltaTime);
        }
    }


}
