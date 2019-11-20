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
    
    //Buy and Sell Price
    private int _value;
    
    private int _damage;
    private int _range;
    private int _fireRate;
    private Texture2D _iconName;
    private GameObject _meshName;

    
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
    
    //allows us to include a description
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    //allows us to assign the level of protection
    public int Range
    {
        get { return _range; }
        set { _range = value; }
    }
    //allows us to show the offensive capabilities
    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    //allows us to assign the level of healing 
    public int FireRate
    {
        get { return _fireRate; }
        set { _fireRate = value; }
    }
    //allows us to see the price of something
    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }
   
   
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
