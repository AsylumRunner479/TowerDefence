using UnityEngine;

public class Item
{

    //this script is designed to assign a bunch of options and reference type for all the items you can get in the game
    #region Variables
    private int _id;
    //id of the item for programmers and developers
    private string _name;
    private string _description;
    //Amount of items of that type...Stackable
    private int _amount;
    //Buy and Sell Price
    private int _value;
    public static bool Money;
    private int _damage;
    private int _armour;
    private int _heal;
    private Texture2D _iconName;
    private GameObject _meshName;

    private ItemTypes _type;
    #endregion
    #region Properities
    //gives a database of names
    public Texture2D IconName
    {
        get { return _iconName; }
        set { _iconName = value; }
    }
    public GameObject MeshName
    //shows what the object looks like
    {
        get { return _meshName; }
        set { _meshName = value; }
    }
    //gives the item a category
    public ItemTypes ItemType
    {
        get { return _type; }
        set { _type = value; }
    }
    //allows us to include a description
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    //allows us to assign the level of protection
    public int Armour
    {
        get { return _armour; }
        set { _armour = value; }
    }
    //allows us to show the offensive capabilities
    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    //allows us to assign the level of healing 
    public int Heal
    {
        get { return _heal; }
        set { _heal = value; }
    }
    //allows us to see the price of something
    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }
    //how many of the object do you have in inventory
    public int Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    //
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    //sets the id in the index
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    #endregion


    // Start is called before the first frame update

}
//lists out the various item types available
public enum ItemTypes
{
    Armour,
    Weapon,
    Potion,
    Money,
    Quest,
    Food,
    Ingredient,
    Craftable,
    Misc,

}