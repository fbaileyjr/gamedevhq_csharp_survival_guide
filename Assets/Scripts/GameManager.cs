using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool IsGameOver { get; private set; }
    //private bool isGameOver;

    //public bool IsGameOver
    //{
    //   get
    //  {
    //        return isGameOver;
        //}
        //set
        //{
        //    if (value == true)
        //    {
        //        Debug.Log("Oh no! The game is over!");
        //    }
        //    isGameOver = value;
        //}
    //}

    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        if (IsGameOver)
        {
            Debug.Log("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IsGameOver = true;
        }
    }

}
