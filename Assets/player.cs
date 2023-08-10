using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public int itemID;
    public string name;
    public string description;
}
public class Player : MonoBehaviour
{

    public Item[] myItems;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in myItems)
        {
            Debug.Log(item.name);
            Debug.Log(item.itemID);
            Debug.Log(item.description);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);
            Debug.Log("randomID is: " + randomID);
            Debug.Log(myItems[randomID].description);
        }
    }

}
 