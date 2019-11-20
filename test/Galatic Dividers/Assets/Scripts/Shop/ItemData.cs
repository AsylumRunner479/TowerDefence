
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemId)
    {
        #region Variables

        //id of the item for programmers and developers
        string name = "";
        string description = "";
        //Amount of items of that type...Stackable
        int amount = 0;
        //Buy and Sell Price
        int value = 0;
        int damage = 0;
        int armour = 0;
        int heal = 0;
        string iconName = "";
        string meshName = "";
        //itemId is used in the game as a shorthand for referencing different items and assign value to the stats from Item
        ItemTypes type = ItemTypes.Misc;
        switch (itemId)
        {
            //an index of all the items you can get in this world and what type they are
            #region Armour 0-99
            case 0:
                name = "LightArmour";
                description = "helps you a bit";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 100;
                damage = 0;
                armour = 1;
                heal = 0;
                iconName = "Armour/Light";
                meshName = "Armour/Light";
                type = ItemTypes.Armour;
                break;
            case 1:
                name = "MedArmour";
                description = "helps you";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 300;
                damage = 0;
                armour = 2;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Armour;
                break;
            case 2:
                name = "HeavyArmour";
                description = "helps you a lot";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 3;
                heal = 0;
                iconName = "Armour/Heavy";
                meshName = "Armour/Heavy";
                type = ItemTypes.Armour;
                break;
            #endregion
            #region Weapeon 100-199
            case 100:
                name = "dagger";
                description = "stabby death";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 100;
                damage = 1;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/dagger";
                meshName = "Weapeon/dagger";
                type = ItemTypes.Weapon;
                break;
            case 101:
                name = "Sword";
                description = "slashy death";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 300;
                damage = 2;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/sword";
                meshName = "Weapeon/sword";
                type = ItemTypes.Weapon;
                break;
            case 102:
                name = "Axe";
                description = "hacky death";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1000;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.Weapon;
                break;


            #endregion
            #region Potion 200-299
            case 200:
                name = "minHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1;
                damage = 0;
                armour = 0;
                heal = 10;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.Potion;
                break;
            case 201:
                name = "medHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 3;
                damage = 0;
                armour = 0;
                heal = 30;
                iconName = "Potion/medHealth";
                meshName = "Potion/medHealth";
                type = ItemTypes.Potion;
                break;
            case 202:
                name = "maxHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 100;
                iconName = "Potion/maxHealth";
                meshName = "Potion/maxHealth";
                type = ItemTypes.Potion;
                break;
            #endregion
            #region Food 300-399
            case 300:
                name = "Apple";
                description = "Munchies and Crunchies";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Food;
                break;
            case 301:
                name = "Meat";
                description = "Lisa does not approve";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 5;
                iconName = "Food/Meat";
                meshName = "Food/Meat";
                type = ItemTypes.Food;
                break;
            case 302:
                name = "Pizza";
                description = "Mamma Mia";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 15;
                iconName = "Food/Pizza";
                meshName = "Food/Pizza";
                type = ItemTypes.Food;
                break;
            #endregion
            #region Ingredient 400-499
            case 400:
                name = "wood";
                description = "Got wood";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.Ingredient;
                break;
            case 401:
                name = "stone";
                description = "don't get high";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/stone";
                meshName = "Ingrediant/stone";
                type = ItemTypes.Ingredient;
                break;
            case 402:
                name = "steel";
                description = "It's real";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 50;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/steel";
                meshName = "Ingrediant/steel";
                type = ItemTypes.Ingredient;
                break;
            #endregion
            #region Craftable 500-599
            case 500:
                name = "mushroom";
                description = "get high";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Craftable;
                break;
            case 501:
                name = "grass";
                description = "get high";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/grass";
                meshName = "Craftable/grass";
                type = ItemTypes.Craftable;
                break;
            case 502:
                name = "flower";
                description = "very pretty";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 50;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/flower";
                meshName = "Craftable/flower";
                type = ItemTypes.Craftable;
                break;
            #endregion
            #region Quest 600-699
            case 600:
                name = "purple key";
                description = "opens purple doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.Quest;
                break;
            case 601:
                name = "yellow key";
                description = "opens yellow doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/yellow";
                meshName = "Quest/yellow";
                type = ItemTypes.Quest;
                break;
            case 602:
                name = "green key";
                description = "opens green doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/green";
                meshName = "Quest/green";
                type = ItemTypes.Quest;
                break;
            #endregion
            #region Misc 700-799
            case 700:
                name = "diamond";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Misc;
                break;
            case 701:
                name = "onyx";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/black";
                meshName = "Misc/black";
                type = ItemTypes.Misc;
                break;
            case 702:
                name = "gold";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 100;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/yellow";
                meshName = "Misc/yellow";
                type = ItemTypes.Misc;
                break;
                #endregion
        }
        Item temp = new Item
        {

            ID = itemId,
            Name = name,
            Description = description,
            Value = value,
            Amount = amount,
            Damage = damage,
            Armour = armour,
            Heal = heal,
            //loads the icon and gameobject from the folders when needed
            IconName = Resources.Load("Icons/" + iconName) as Texture2D,
            MeshName = Resources.Load("Prefabs/" + meshName) as GameObject,
            ItemType = type

        };
        return temp;
        #endregion
    }
}
