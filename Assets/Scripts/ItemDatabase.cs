using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Item[] items;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(items[0].Name);
    }
}