using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{


    // list
    //public List<GameObject> enemiesToSpawn = new List<GameObject>();

    //array
    //public GameObject[] objectsToSpawn = new GameObject[10];

    // Challenge: Create a list of names and print out each one
    // When you hit the space key, "Remove" a random element from the list and re-print the names

    public List<string> Names = new List<string>();

    private void Start()
    {
        // objectsToSpawn[0] = new GameObject();
        // enemiesToSpawn.Add(new GameObject);

        // accessing the objects are the same
        //objectsToSpawn[2].name = "Frank";

        Names.Add("Bubba");
        Names.Add("Cat");
        Names.Add("Dog");
        Names.Add("LemonLime");
        Names.Add("Tex");
        Names.Add("T-Rex");
        Names.Add("CondorMan");
        Names.Add("Courage the Cowardly Dog");
        Names.Add("Sting");
        Names.Add("Player One");
        Debug.Log("The length of the list is: " + Names.Count);
        foreach(string x in Names)
        {
            Debug.Log("The name is: " + x);
        }
    }

    private void Update()
    { 
        if (Names.Count > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            var nameToRemove = Names[Random.Range(0, Names.Count)];
            Names.Remove(nameToRemove);
            foreach (string x in Names)
            {
                Debug.Log("The name is: " + x);
            }
            Debug.Log("The length of the list is: " + Names.Count);
            Debug.Log("The name removed from the list is: " + nameToRemove);
        }
    }

}
