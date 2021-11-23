using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int id;
    public string name;
    public string description;

    public Item(Item d)
    {
        id = d.id;
        name = d.name;
        description = d.description
    }
}
