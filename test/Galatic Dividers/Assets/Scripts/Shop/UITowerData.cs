using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace TowerDefense
{
    [RequireComponent(typeof(Button))]
    public class UITowerData : MonoBehaviour
    {
        public string title;
        public int cost;
        public string details;
        [Header("References")]
        public Selector selector;
        public GameObject overlay;
        [Header("UI")]
        public Text txtTitle;
        public Text txtCost;
        public Text txtDetails;

        // Update is called once per frame
        void Update()
        {
            RefreshData();
        }

        void RefreshData()
        {
            txtTitle.text = "Tower: " + title;
            txtCost.text = "Cost: " + cost;
            txtDetails.text = "Details: " + details;
            //int score = GameManager.Instance.GetScore();
            //if (score > cost)
           // {
            ///    overlay.SetActive(false);
            //}
            //else
            //{
                //overlay.SetActive(true);
            //}
        }

        public void BuyTower(int index)
        {
            //int score = GameManager.Instance.GetScore();
            //if (score > cost)
            {
                selector.SelectTower(index);
                //GameManager.Instance.RemoveScore(cost);
            }
        }
    }
}