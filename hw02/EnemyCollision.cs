using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchWeapons());
    }

    // Update is called once per frame
    void Update()
    {

    }

    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean?
    /* When you don’t specify public or private, methods or variables default to private, 
     * meaning they are only accessible within the class. 
     * The void keyword indicates that a method does not return any value. For example, a method declared as void Movement() performs 
     * its intended actions, such as handling player movement, but does not return any data to the caller. */
    void Movement()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        /* Input.GetAxis() retrieves user input for movement, returning a value between -1 and 1. 
         * transform.Translate() moves the GameObject along a specified direction based on a vector, 
         * adjusting its position in the scene. transform.Rotate() rotates the GameObject around specified axes, changing its orientation. */
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }



    void Shoot()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        /* The code snippet is using Unity's Old Input System, as it involves direct methods 
         * like Input.GetAxis(). In the if statement, Instantiate creates a new instance of a 
         * GameObject or prefab at runtime, generating a copy of the specified object in the scene. */


        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.
    */
    public class Weapon
    {
        int[] weapons = { 0, 0, 0 };
        int currenWeaponIndex = 0;

        public void UpdateWeapon()
        {
            //weapons[currenWeaponIndex] = 0;

            //currenWeaponIndex += 1;
            /* if(currenWeaponIndex == 3)
             {
                 currenWeaponIndex = 0;
             }
             weapons[currenWeaponIndex] = 1; */
            int i = 0;
            while (true)
            {
                currenWeaponIndex = i;
                weapons[currenWeaponIndex] = i;
                i++;

                if (i = 3)
                {
                    i = 0;
                }
            }

        }
    }

    /*
    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */

    Weapon weapon;

    public IEnumerator SwitchWeapons()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            weapon.UpdateWeapon();

        }
    }

}