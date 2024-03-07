using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameManager gm = new GameManager();
    public Test()
    {
    }
}


public class GameManager : MonoBehaviour
{

    public bool IsGameOver { get; private set; }

    private float _speed;

    public float Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
    }

    private string _name;
    public string Name { get; set; }

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
        Speed = 10f;
        Debug.Log(Speed);
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
