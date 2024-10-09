using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
Homework Problems

It is Barbie's Birthday and she is hosting a birthday party!
We are in a 2D World celebrating Barbie's Birthday and we are getting ready to break the pinata. 
First, we would like to position Barbie and the pinata correctly. 

Barbie is 5'9'' or 1.75 meters tall. 
She is standing 2 feet or 0.6 meters away from the her party pinata.
The party pinata is hanging 8.2 feet or 2.5 meters high from the ground.
Assume that the angles between the distance of the pinata to the ground and Barbie's distance to the pinata create a 90 degree angle. 

TODO: Problem 1: Barbie is holding a bat to swing at the pinata. What should be the magnitude the bat should swing at? Make sure the check for edge cases including:
        * Barbie has only three chances to swing at the pinata before it is the next player's turn
        * If Barbie runs out of turns, a message should display that Barbie's turn is over and it is the next player's turn
        Tracking turns: Barbie gets three chances to hit the piñata.
        Swing Magnitude: While this game doesn't involve real physics, we can assume a magnitude based on the distance calculated 
        using Pythagorean theorem from Barbie to the piñata. 
        
*/
public class BarbieBirthday : MonoBehaviour
{

    [SerializeField] Transform pinata; // Pinata's position
    [SerializeField] Transform barbie; // Barbie's position
    [SerializeField] float maxSwingAttempts = 3; // Max attempts
    private int currentSwingAttempts = 0; // Current number of swings



    // Transform for Barbie's party pinata
    [SerializeField] Transform pinata;

    // The pinata's rotation along the X axis for the first successful hit (Quaternion)
    [SerializeField] Quaternion rotationX;

    // The pinata's rotation along the Y axis for the second successful hit (Quaternion)
    [SerializeField] Quaternion rotationY;

    // Particle System for the third successful hit
    [SerializeField] ParticleSystem candyExplosion;

    // Barbie's height is Barbie is 5'9'' or 1.75 meters tall
    private Vector2 barbieHeight;

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance;

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight;


    // The distance required to hit the pinata
    private float distanceToPinata;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the distance using Pythagoras theorem
        float heightDifference = 2.5f - 1.5f; // Pinata height - Barbie's assumed shoulder height
        float horizontalDistance = 0.6f; // Horizontal distance between Barbie and Pinata
        distanceToPinata = Mathf.Sqrt(Mathf.Pow(horizontalDistance, 2) + Mathf.Pow(heightDifference, 2));
    }

    // Barbie attempts to swing
    public void SwingAtPinata()
    {
        if (currentSwingAttempts < maxSwingAttempts)
        {
            currentSwingAttempts++;
            Debug.Log($"Barbie swings! Attempt {currentSwingAttempts}/{maxSwingAttempts}");

            // Call a method to check if the swing was successful (dummy check for now)
            if (CheckIfHit())
            {
                Debug.Log("Barbie hits the pinata!");
                // Add logic to handle what happens when the piñata is hit
            }
            else
            {
                Debug.Log("Barbie misses!");
            }
        }
        else
        {
            Debug.Log("Barbie's turn is over. It is the next player's turn.");
        }
    }

    // Check if the bat hits the pinata
    private bool CheckIfHit()
    {
        // Assuming a simple random hit chance for demonstration
        return Random.Range(0f, 1f) > 0.5f;
    }
}


    // Update is called once per frame
    void Update()
    {
        /*
        TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
        */      
        //Vector2 relativePosition = pinata.position - pinata.position;


    // Check if Barbie is facing the piñata
    Vector3 directionToPinata = pinata.position - barbie.position;
    Quaternion targetRotation = Quaternion.LookRotation(directionToPinata);

    // Compare the target rotation with Barbie's current rotation
    if (Quaternion.Angle(barbie.rotation, targetRotation) < 5f) // Allowing a small angle for tolerance
    {
        // Barbie is looking at the piñata, allow swing
        Debug.Log("Barbie is facing the pinata, she can swing!");
        if (Input.GetKeyDown(KeyCode.Space)) // For example, the spacebar triggers a swing
        {
            SwingAtPinata();
        }
    }
    else
    {
        // Barbie is not facing the piñata
        Debug.Log("Barbie is not facing the pinata, she cannot swing!");
    }
    /*
    TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
    If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
        * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
        * Example: result = Quaternion.Euler(0,rotation, 0) * result;
        * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
        * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
    */

    // Track the number of successful hits
private int hitCount = 0;

// This method is called when Barbie successfully hits the pinata
private void RotatePinata()
{
    hitCount++;

    // Rotation logic based on the number of hits
    if (hitCount == 1)
    {
        // First hit: Rotate along the X axis
        pinata.rotation = Quaternion.Euler(45, 0, 0); // Example rotation
    }
    else if (hitCount == 2)
    {
        // Second hit: Rotate along the X and Y axes
        pinata.rotation = Quaternion.Euler(45, 45, 0); // Example rotation
    }
    else if (hitCount == 3)
    {
        // Third hit: Trigger candy explosion and reset rotation
        candyExplosion.Play();
        Debug.Log("The piñata breaks! Candy explosion!");
    }
}
}
}