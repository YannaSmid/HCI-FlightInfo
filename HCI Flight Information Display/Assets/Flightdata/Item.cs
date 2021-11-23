using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]

  public class Item : MonoBehaviour
    {
        public int id;
        public string name;
        public string description;

        public Item(Item d)
        {
            id = d.id;
            name = d.name;
            description = d.description;
        }
    }

