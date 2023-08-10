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
    private int _random;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _random = Random.Range(0, names.Length);
            Debug.Log("Random number is: " + _random);
            Debug.Log("The last kids name is: " + names[_random]);
            Debug.Log("The kid's age is: " + ages[_random]);
            Debug.Log("The kid's favorite car is: " + cars[_random]);
        }
    }

}
 