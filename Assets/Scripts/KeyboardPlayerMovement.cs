using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlayerMovement : MonoBehaviour
{
    // Public reference to the player GameObject.
    public GameObject playerGameObject;

    // Variable to control turn speed.
    public float turnSpeed;

    // Variable to control movement speed.
    public float movementSpeed;

    // Update is called once per frame  
    void Update()
    {
        // Check if the Up Arrow key is pressed.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move the player object forward.
            playerGameObject.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }

        // Check if the Down Arrow key is pressed.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move the player object backward.
            playerGameObject.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }

        // Check if the Left Arrow key is pressed.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Rotate the player object to the left.
            playerGameObject.transform.Rotate(Vector3.up, -turnSpeed);
        }

        // Check if the Right Arrow key is pressed.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Rotate the player object to the right.
            playerGameObject.transform.Rotate(Vector3.up, turnSpeed);
        }
    }
}
