using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    // list
    public List<GameObject> enemiesToSpawn = new List<GameObject>();

    //array
    public GameObject[] objectsToSpawn = new GameObject[10];

    private void Start()
    {
        // objectsToSpawn[0] = new GameObject();
        // enemiesToSpawn.Add(new GameObject);
        
        // accessing list and dict is the same
        objectsToSpawn[2].name = "Frank";

    }

}
