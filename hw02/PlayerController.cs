    // TODO: Problem 1: Write in the comments what each line of code is doing.
    // What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
    using System.Collections; // using system collections of classes and interfaces that define collections of objects, such as lists, queues, hash tables, bit arrays, and dictionaries
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        string name = "MadhupriyaGame";
        float movespeed = 5f;
        float gravity = 9.81f;
        float jumpspeed = 5f;

        /* 
        TODO: Problem 2: We are trying to move our player in an open world game. We would like the player to be able to move
        foward, backward, left, and right. In addition, the player should be able to jump and adapt to the world's gravity.
        First, we will need to define some variables in order to control our player with the WASD keys and the Space bar for it to jump. 
        Please define the following private variables and print them out to Unity's console: 
                    1. Player or Character's Name
                    2. Movement Speed as a float
                    3. Gravity Value as a float
                    4. Jump Speed as a float
    
        When the game starts, we would like to find our character. In our Unity Editor, we have a 3D model of our player and the player is 
        represented as a component in Unity. How do we grab our player controller in code and where should we write this line of code in this
        C# document (PlayerController.cs)? 
        
        -- By refering to them as GameObject.
        */
    
        // Start is called before the first frame update
        void Start()
        {
            // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
            // What is the difference between Start() and Update()?
            /* Answer: 
            Start() --
            This function is called before the first frame update, only if the script instance is enabled. It's used to initialize things that don't need constant updates, like loading resources, configuring components, or initializing scripts. 

            Update() --
            This function is called once per frame, throughout the script's lifetime. It's the main function used for frame updates. Lopps are very often used in update() because
            they are constantly updating
        */
        }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 


        /*An if statement is a programming construct that allows a program to make decisions based on conditions. It controls the flow of a program by executing different 
          code blocks depending on whether a condition is true or false. 
        */
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }

        transform.Translate(movement * movespeed * Time.deltaTime, Space.World);
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime
    }
      
    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")]
    [SerializeField] private InputAction movement;
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable()
    {
    movement.Enable();
    }

    private void OnDisable()
    {
    movement.Disable();
    }
    }