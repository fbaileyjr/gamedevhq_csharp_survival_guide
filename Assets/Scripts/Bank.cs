using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    protected string branchName;
    protected string location;
    protected string cashInVault;

    protected void CheckBalance()
    {
        Debug.Log("CheckingBalance" + branchName);
    }

    protected void Withdrawl()
    {
        Debug.Log("Withdrawling Money from:" + branchName);
    }

    protected void Deposit()
    {
        Debug.Log("Depositinh Money to:" + branchName);
    }
}
