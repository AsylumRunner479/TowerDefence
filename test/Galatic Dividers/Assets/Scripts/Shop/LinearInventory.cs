using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInventory : MonoBehaviour
{
    #region Variables
    public static List<Item> inv = new List<Item>();
    public static bool showInv;
    public Item item;
    public PlayerHandler player;
    public Vector2 scr;
    public Item selectedItem;
    public static int money;
    public Vector2 scrollPos;

    public Transform dropLocation;
    [System.Serializable]
    public struct EquippedItems
    {
        public string slotName;
        public Transform location;
        public GameObject equippedItem;
    };
    public EquippedItems[] equippedItems;
    public bool invFilterOptions;
    public GUISkin invSkin;
    public GUIStyle titleStyle;
    #endregion

    void Start()
    {
        //adds on a bunch of different items in your inventory
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        selectedItem = null;
    }

    private void Update()
    {
        // makes the inventory open and close based on whther you press tab.





        if (Input.GetKey(KeyCode.I))
        {
            inv.Add(ItemData.CreateItem(Random.Range(0, 3)));
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {

        }
    }
    void DisplayInv()
    {


        if (inv.Count <= 34)
        {
            for (int i = 0; i < inv.Count; i++)
            {
                if (GUI.Button(new Rect(0.5f * scr.x, 0.25f * scr.y + i * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
                {
                    selectedItem = inv[i];
                }
            }
        }
        else// we have more items than screen space
        {
            //our move position of our scroll window
            scrollPos =
           //the Start of our scroll view
           GUI.BeginScrollView(
           //our position and size of our window
           new Rect(0, 0.25f * scr.y, 3.75f * scr.x, 8.5f * scr.y),
           //our current position in the scroll view
           scrollPos,
           //viewable area
           new Rect(0, 0, 0, inv.Count * (0.25f * scr.y)),
            //can we see our Horizontal bar?
            false,
           //Can we see our Vertical Bar?
           true);

            #region Scrollable Space
            //displays all the invenory items in a list format
            for (int i = 0; i < inv.Count; i++)
            {
                if (GUI.Button(new Rect(0.5f * scr.x, i * (0.25f * scr.y), 3 * scr.x, 0.25f * scr.y), inv[i].Name))
                {
                    selectedItem = inv[i];
                }
            }
            #endregion
            GUI.EndScrollView();
        }

    }
    void OnGUI()
    {
        if (showInv && !PauseMenu.isPaused)
        {
            scr = new Vector2(Screen.width / 16, Screen.height / 9);
            GUI.skin = invSkin;

            DisplayInv();


            UseItem();


        }
        void UseItem()
        {
            //displays all the stat and options on what to do with them
            GUI.Box(new Rect(4f * scr.x, 0.25f * scr.y, 3 * scr.x, 0.25f * scr.y), selectedItem.Name, titleStyle);
            GUI.skin = invSkin;
            GUI.Box(new Rect(4f * scr.x, 0.5f * scr.y, 3 * scr.x, 3 * scr.y), selectedItem.IconName);
            GUI.Box(new Rect(4f * scr.x, 3.5f * scr.y, 3 * scr.x, 3 * scr.y), selectedItem.Description + "\nAmount: " + "\nPrice: $" + selectedItem.Value);





            // this allows the player to throw away items they don't need or want
            if (GUI.Button(new Rect(5.5f * scr.x, 6.5f * scr.y, 1.5f * scr.x, 0.25f * scr.y), "place"))
            {
                //check if the item is equipped
                for (int i = 0; i < equippedItems.Length; i++)
                {
                    if (equippedItems[i].equippedItem != null && selectedItem.Name == equippedItems[i].equippedItem.name)
                    {
                        //if so destroy from scene
                        Destroy(equippedItems[i].equippedItem);
                    }
                }

                //spawn item at droplocation
                GameObject itemToDrop = Instantiate(selectedItem.MeshName, dropLocation.position, Quaternion.identity);
                //apply gravity and make sure its named correctly 
                itemToDrop.name = selectedItem.Name;
                itemToDrop.AddComponent<Rigidbody>().useGravity = true;


                inv.Remove(selectedItem);
                selectedItem = null;
                return;


            }
        }
    }
}


