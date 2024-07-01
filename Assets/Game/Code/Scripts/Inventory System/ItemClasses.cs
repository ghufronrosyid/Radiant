using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClasses : MonoBehaviour
{
    public class Item
    {
        public string Name { get; private set; }
        public string ItemType { get; private set; }

        public Item(string name, string itemType)
        {
            Name = name;
            ItemType = itemType;
        }

        public override string ToString()
        {
            return $"{ItemType}: {Name}";
        }
    }

    public class Projectile : Item
    {
        public Projectile(string name) : base(name, "Projectile") { }
    }

    public class Debris : Item
    {
        public Debris(string name) : base(name, "Debris") { }
    }

    public class Ore : Item
    {
        public Ore(string name) : base(name, "Ore") { }
    }

    public class Beam : Item
    {
        public Beam(string name) : base(name, "Beam") { }
    }
}
