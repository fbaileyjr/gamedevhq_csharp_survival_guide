using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 1)
        {
            health = 0;
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Damage(5);
        }
    }

}
