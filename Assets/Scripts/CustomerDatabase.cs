using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer bubba;
    public Customer spiderman;
    public Customer johnny;
    // Start is called before the first frame update
    void Start()
    {
        bubba = AddCustomer("bubba", "gump", 32, "male", "fisherman");
        spiderman = AddCustomer("spider", "man", 23, "male", "webhead");
        johnny = AddCustomer("johnny", "knoxville", 49, "male", "stuntman");

        Debug.LogError("Name for first customer is: " + bubba.FirstName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Customer AddCustomer(string FirstName, string LastName, int Age, string Gender, string Occupation)
    {
        var customerObject = new Customer(FirstName, LastName, Age, Gender, Occupation);
        return customerObject;
    }
}
