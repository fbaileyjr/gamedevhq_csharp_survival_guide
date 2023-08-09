using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program where you increment the value of speed by 5 every second 
    // when speed is greater than MaxSpeed, stop incrementing (Random between 60 and 120)
    // Hint use a coroutine

    int speed = 0;
    int MaxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        MaxSpeed = Random.Range(60, 120);
        Debug.Log("MaxSpeed is: " + MaxSpeed);
        StartCoroutine(AddSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddSpeed()
    {
        while (speed < MaxSpeed)
        {
            Debug.Log("Current speed is: " + speed);
            speed += 5;
            yield return new WaitForSeconds(1.0f);
        }
    }

}
 