using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string Name;
    public int id;
    public string description;
    public Sprite icon;

    public Item()
    {

    }

    public Item(string name, int id, string description)
    {
        this.Name = name;
        this.id = id;
        this.description = description;
    }

}
