// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 

/* The "System. Collections" namespace contains the Non-generic Collection classes. Non-generic collections
 * store elements in object arrays internally, allowing them to hold any data type. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /* 
    TODO: Problem 2: We are trying to move our player in an open world game. We would like the player to be able to move
    foward, backward, left, and right. In addition, the player should be able to jump and adapt to the world's gravity.
    First, we will need to define some variables in order to control our player with the WASD keys and the Space bar for it to jump. 
    Please define the following private variables and print them out to Unity's console: 
                1. Player or Character's Name
                2. Movement Speed as a float
                3. Gravity Value as a float
                4. Jump Speed as a float */

    private string Name = "Madhupriya";
    private float MovementSpeed = 5.0f;
    private float Gravity = 9.81f;
    private float JumpSpeed = 8.0f;

    /*
    When the game starts, we would like to find our character. In our Unity Editor, we have a 3D model of our player and the player is 
    represented as a component in Unity. How do we grab our player controller in code and where should we write this line of code in this
    C# document (PlayerController.cs)?

    Answer:
    In Unity, you typically use the GetComponent() method to access the player controller or any other component. If your player is a GameObject
    with a specific component, this method allows you to obtain that component from the GameObject.
    */

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        /* You would put code in the Start() function when you need it to run once at the beginning of the game or when the script is first initialized. Common uses include setting up initial values, finding components, or configuring game objects.

        In contrast, the Update() function is used for code that needs to run continuously every frame, such as handling player input, checking conditions, 
        or updating animations. So, use Start() for initialization and Update() for tasks that need to happen repeatedly throughout the game.*/


        // What is the difference between Start() and Update()?

        /* The main difference between Start() and Update() in Unity is when and how often they are called:

        Start() is called once at the beginning of the game or when a script is first initialized.
        Used for initialization tasks like setting up variables, finding components, or preparing game objects before gameplay begins.
        
        Update() is called every frame during the game.
        Used for code that needs to run continuously, such as handling player input, movement, physics updates, or animations. */
    }

    // Update is called once per frame
    void Update()
{
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime


        // Get input from WASD keys
        float horizontal = Input.GetAxis("Horizontal"); // A and D keys
        float vertical = Input.GetAxis("Vertical");     // W and S keys

        // Create a movement vector
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Move the player
        characterController.Move(movement * movementSpeed * Time.deltaTime);

    }

// TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
// What do Header, SerializeField, and Tooltip mean? 


    // Adds a label above the field in the Unity Inspector for organizational purposes
    [Header("General Setup Settings")]
    // Makes the 'movement' field visible in the Unity Inspector and allows it to be set in the editor
    [SerializeField] private InputAction movement;

    // Adds a tooltip that appears when you hover over the field in the Unity Inspector
    // Makes the 'controlSpeed' field visible in the Unity Inspector and allows it to be set in the editor
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;

    // Adds a tooltip that appears when you hover over the field in the Unity Inspector
    // Makes the 'xRange' field visible in the Unity Inspector and allows it to be set in the editor
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;

    // Adds a tooltip that appears when you hover over the field in the Unity Inspector
    // Makes the 'yRange' field visible in the Unity Inspector and allows it to be set in the editor
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
/* In Unity, OnEnable() is called when a script or GameObject is enabled, allowing for initialization or 
 * event subscription, while OnDisable() is called when the script or GameObject is disabled, useful for cleanup or 
 * unsubscribing from events. For Unity's new Input System, movement.Enable() activates input controls, making them responsive, 
 * and movement.Disable() deactivates them, stopping input reception. These methods manage input actions based on the script's active state.
 * 
 * */
private void OnEnable()
{
movement.Enable();
}

private void OnDisable()
{
movement.Disable();
}
}