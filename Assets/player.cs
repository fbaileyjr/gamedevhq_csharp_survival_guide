using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// create a variable to store your name
    /// create a variable to store your age
    /// create a variable to store your speed
    /// create a health variable
    /// create a score variable
    /// create a speed variable
    /// variable to check if all keys were collected
    /// variable for ammo count

    public string myName = "Frank";
    public int myAge = 44;
    public float mySpeed = 12.50f;
    public int myHealth = 100;
    public int score = 0;
    public bool hasAllKeys = true;
    public int ammoCount = 20;


    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("My name is: " + myName);
        // Debug.Log("My Age is: " + myAge);
        // Debug.Log("My speed is: " + mySpeed);
        // Debug.Log("My health is: " + myHealth);
        // Debug.Log("My score is: " + score);
        // Debug.Log("Has all the keys been collected? " + hasAllKeys);
        // Debug.Log("My ammo count is: " + ammoCount);

        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
