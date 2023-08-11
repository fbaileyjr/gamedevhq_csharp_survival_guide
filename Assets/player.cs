using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program where you assign a cube in the inspector and when you hit
    // the space key, you pass that object into a function called ChangeColor. The function should take both the GameObject
    // and a color to change to and the operation should be handled within the function

    public GameObject cube;
    public Color colorToChangeInto;

    // Start is called before the first frame update
    void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, colorToChangeInto);
        }
    }

    void ChangeColor(GameObject cube, Color colorChange)
    {
        cube.GetComponent<MeshRenderer>().material.color = colorChange;
    }

}
