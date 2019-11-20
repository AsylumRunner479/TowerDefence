
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemId)
    {
         

        //id of the item for programmers and developers
        string name = "";
        string description = "";
        //Amount of items of that type...Stackable

        //Buy and Sell Price
        int value = 0;
        int damage = 0;
        int range = 0;
        int fireRate = 0;
        string iconName = "";
        string meshName = "";
        //itemId is used in the game as a shorthand for referencing different items and assign value to the stats from Item

        switch (itemId)
        {
            //an index of all the items you can get in this world and what type they are
            
            case 0:
                name = "BasicTurret";
                description = "helps you a bit";
                //Amount of items of that type...Stackable

                //Buy and Sell Price
                value = 100;
                damage = 0;
                range = 1;
                fireRate = 0;
                iconName = "Turret/Light";
                meshName = "Turret/Light";

                break;
            case 1:
                name = "RailGun";
                description = "helps you";
                //Amount of items of that type...Stackable

                //Buy and Sell Price
                value = 300;
                damage = 0;
                range = 2;
                fireRate = 0;
                iconName = "Turret/Med";
                meshName = "Turret/Med";

                break;

                Item temp = new Item
                {

                    ID = itemId,
                    Name = name,
                    Description = description,
                    Value = value,

                    Damage = damage,
                    Range = range,
                    FireRate = fireRate,
                    //loads the icon and gameobject from the folders when needed
                    IconName = Resources.Load("Icons/" + iconName) as Texture2D,
                    MeshName = Resources.Load("Prefabs/" + meshName) as GameObject,


                };
                return temp;
                
        }
    }
}
