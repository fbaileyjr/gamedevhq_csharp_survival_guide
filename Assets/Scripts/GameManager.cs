using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{


    // list
    //public List<GameObject> enemiesToSpawn = new List<GameObject>();

    //array
    //public GameObject[] objectsToSpawn = new GameObject[10];

    // Challenge: Create a list/array of 3 gameObjects to spawn and randomly spawn with a random position on the screen
    // betwee -10 and +10 on the x/y when you hit the space key. 
    // Every object you spawn should be stored into a list called objectsCreated. 
    // When you have spawn 10 objects, you will no longer be able to spawn object and will turn
    // all objects created GREEN and then CLEAR the list

    public GameObject[] objectsToSpawn = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();
    public int SpawnCount = 0;

    private void Start()
    {
        // objectsToSpawn[0] = new GameObject();
        // enemiesToSpawn.Add(new GameObject);

        // accessing the objects are the same
        //objectsToSpawn[2].name = "Frank";

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SpawnCount < 10)        
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            objectsCreated.Add(Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], randomPosition, transform.rotation));
            SpawnCount++;
        }

        if (SpawnCount == 10)
        {
            // turn all objects green
            // clear list
            foreach (GameObject x in objectsCreated)
            {
                var objectRenderer = x.GetComponent<Renderer>();
                objectRenderer.material.SetColor("_Color", Color.green);
            }
            objectsCreated.Clear();
        }
    }
}