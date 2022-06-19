using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// public or private reference
    /// public = everyone access it
    /// private = only the script can access it
    /// data type (strings, bool, float, int)
    /// every variable needs a name
    /// optional -- a value
    /// </summary>

    // variable for my name
    // variable for my age
    // for my location

    public string myName = "Frank";
    public int myAge = 26;
    public string myLocation = "Atlanta";
    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is: " + myName);
        Debug.Log("My Age is: " + myAge);
        Debug.Log("My Location is: " + myLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
