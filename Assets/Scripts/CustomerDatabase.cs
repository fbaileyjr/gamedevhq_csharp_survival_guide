using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer[] customers;

    // Start is called before the first frame update
    void Start()
    {

        Debug.LogError("Name for first customer is: " + customers[0].FirstName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
