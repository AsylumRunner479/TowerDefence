using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Selector : MonoBehaviour
    {
        public GameObject[] towers;
        public GameObject[] holograms;
    public float towerPrice;
        private int currentTower = 0;

        void Update()
        {
            DisableAllHolograms();

            // Perform raycast from mouse position
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(mouseRay, out hit))
            {
                // Is the hit a placeable AND is it available?
                Placeable p = hit.transform.GetComponent<Placeable>();
                if (p && p.isAvailable)
                {
                    // Get current hologram (tower)
                    GameObject hologram = holograms[currentTower];
                    // Activate hologram
                    hologram.SetActive(true);
                    // Position hologram
                    hologram.transform.position = p.transform.position;

                    // Is left mouse button down?
                    if (Input.GetMouseButtonDown(0) && Shop.money >= 0)
                    {
                        // Get current tower prefab
                        GameObject towerPrefab = towers[currentTower];

                        // Spawn tower there
                        Instantiate(towerPrefab, p.GetPivotPoint(), p.transform.rotation, transform);

                        // Spot is no longer available
                        p.isAvailable = false;

                    Shop.money -= towerPrice;
                    
                    }
                }
            }
        }

        // Disables all referenced holograms
        void DisableAllHolograms()
        {
            foreach (var holo in holograms)
            {
                holo.SetActive(false);
            }
        }

        // Selects a valid tower index
        public void SelectTower(int index)
        {
            // Is index out of range??
            if (index < 0 || index > towers.Length)
                return; // Exit function

            // Set current tower to index
            currentTower = index;
        }

    }
