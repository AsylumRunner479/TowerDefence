using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public LinearInventory inventory;
    public static GameObject tower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            Ray interactionRay;
            interactionRay = Camera.main.ScreenPointToRay
            (new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hitInfo;
            if (Physics.Raycast(interactionRay, out hitInfo, 10))
            {
                switch (hitInfo.collider.tag)
                {
                    
                    case "TowerBase":
                        Debug.Log("hit Tower");
                        inventory.dropLocation.position = tower.position;
                        
                        
                            
                        break;
                   


                }
            }
           
        }
    }
}
