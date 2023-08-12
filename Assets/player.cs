using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create an array of 5 different positions and use a custom method to generate a random index, and then use a custom
    // method to set the position to that sub index

    public Vector3[] randomPositions;

    // Start is called before the first frame update
    void Start()
    {
        updatePosition(randomPositions[randomIndex(randomPositions.Length)]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    int randomIndex(int length)
    {
        return Random.Range(0, length);
    }

    void updatePosition(Vector3 pos)
    {
        transform.position = pos;
    }

  
}
