using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // declare the size (how many elements) through the inspector
    public string[] names;

    public string[] items = new string[5];

    public int[] ages = new int[] { 5, 4, 2, 55, 63 };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(names[0]);
        Debug.Log(items[1]);
        Debug.Log(ages[4]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
 