using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectTD
{
    public class CharacterInventory : MonoBehaviour
    {
        public class Inventory
        {
            private List<Item> items;

            public Inventory()
            {
                items = new List<Item>();
            }

            public void AddItem(Item item)
            {
                items.Add(item);
                Console.WriteLine($"Added {item} to inventory.");
            }

            public void ListItems()
            {
                if (items.Count == 0)
                {
                    Console.WriteLine("Inventory is empty.");
                }
                else
                {
                    Console.WriteLine("Inventory items:");
                    foreach (var item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }


    }
}
