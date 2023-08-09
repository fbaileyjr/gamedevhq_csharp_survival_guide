using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create an array of 5 names and print out the last kids name
    // Create an array of 5 ages that corospond to each kid and print out the last age
    // Create an array of 5 car models and associate them with each kid and print out the last kids favorite car

    // Bonus -- Handle the print out when the space key is pressed

    public string[] names;
    public int[] ages;
    public string[] cars;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("The last kids name is: " + names[names.Length -1]);
            Debug.Log("The kid's age is: " + ages[ages.Length - 1]);
            Debug.Log("The kid's favorite car is: " + cars[cars.Length - 1]);
        }
    }

}
 