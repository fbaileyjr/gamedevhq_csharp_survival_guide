using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Gender;
    public string Occupation;

    public Customer()
    {
        
    }

    public Customer(string FirstName, string LastName, int Age, string Gender, string Occupation)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
        this.Gender = Gender;
        this.Occupation = Occupation;
        
    }
}
