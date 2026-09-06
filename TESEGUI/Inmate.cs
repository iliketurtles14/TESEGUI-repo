using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TESEGUI
{
    public class Inmate
    {
        public string name;
        public string strength;
        public string speed;
        public string intellect;
        public string opinion;
        public bool flag2001;
        public List<Item> inventory;
        public int character;
        public bool hasShop;
        public List<Item> shopInventory;
        public Inmate(string name, string strength, string speed, string intellect, string opinion, bool flag2001, List<Item> inventory, int character, bool hasShop, List<Item> shopInventory)
        {
            this.name = name;
            this.strength = strength;
            this.speed = speed;
            this.intellect = intellect;
            this.opinion = opinion;
            this.flag2001 = flag2001;
            this.inventory = inventory;
            this.character = character;
            this.hasShop = hasShop;
            this.shopInventory = shopInventory;
        }
        public Inmate Clone()
        {
            return new Inmate(
                name,
                strength,
                speed,
                intellect,
                opinion,
                flag2001,
                CloneItems(inventory),
                character,
                hasShop,
                CloneItems(shopInventory)
            );
        }
        private static List<Item> CloneItems(List<Item> items)
        {
            var clonedItems = new List<Item>();

            if (items == null)
            {
                return clonedItems;
            }

            foreach (Item item in items)
            {
                if(item == null)
                {
                    clonedItems.Add(null);
                }
                else
                {
                    clonedItems.Add(item.Clone());
                }
            }

            return clonedItems;
        }
    }
}
