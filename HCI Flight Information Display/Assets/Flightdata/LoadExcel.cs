using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadExcel : MonoBehaviour
{
    public Item blankItem;
    public List<Item> itemDatabase = new List<Item>();

    public void LoadItemData()
    {
        //Clear database
        itemDatabase.Clear();

        //READ CSV files
        List<Dictionary<string, object>> data = CSVReader.Read("ItemDatabase");
        for (var i = 0; i < data.Count; i++)
        {
            int id = int.Parse(data[i]["id"]).ToString(), System.Globalization.NumberStyles.Integer;
            string name = data[i]["name"].ToString();
            string description = data[i]["description"].ToString();

            AddItem(id, name, description);
        }
    }

    void AddItem(int id, string name, string description)
    {
        Item tempItem = new Item(blankItem);

        tempItem.id = id;
        tempItem.name = name;
        tempItem.description = description;

        itemDatabase.Add(tempItem);
    }
}
