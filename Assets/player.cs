using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program that checks if the player is dead or not. When you the space key, you should damage
    // the player by a random amount. If the player is dead (health less than 1), print out "The player has died!"

    // Bonus: Prevent the damge function from being called once player is dead and no negative health values

    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {



    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(Random.Range(5, 20));
        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (IsDead() == true)
        {
            health = 0;
            Debug.Log("The player has died!");
        }
    }

    public bool IsDead()
    {
        return health < 1;
    }

}
