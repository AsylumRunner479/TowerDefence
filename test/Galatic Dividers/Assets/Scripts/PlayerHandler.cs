using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class PlayerHandler : MonoBehaviour
{
    public bool isDead;
    public float curHealth, maxHealth;
    public GameObject death;
    public Menu menu;
    public GameObject healthCanvas;
    public Image healthBar;
    public HighScores highScoreData = new HighScores();
    
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        highScoreData = XMIManager.ReadData();
        if (highScoreData != null)
        {
            EnemyHandler.highScore = highScoreData.highScore;
        }
        else
        {
            highScoreData = new HighScores();
        }

        
        //healthCanvas = GameObject.FindGameObjectWithTag(healthCanvas);
        healthBar = GameObject.FindGameObjectWithTag("healthBar").GetComponent<Image>();
        isDead = false;
        death.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((curHealth/maxHealth) != healthBar.fillAmount)
        {
            healthBar.fillAmount = (curHealth/maxHealth);
        }
        if (curHealth <= 0)
        {
            isDead = true;
           death.SetActive(true);
           

        }
        else if (curHealth >= 0)
        {
            isDead = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            highScoreData.highScore = EnemyHandler.highScore;

            XMIManager.WriteData(highScoreData);
            EnemyHandler.score = 0;
            menu.ChangeScene(1);
        }
        if (!Input.GetKeyDown(KeyCode.R))
        {

        }
        else
        {
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.buildIndex);
        }

        //if (healthBar.fillAmount < 1 && healthBar.fillAmount > 0)
        //{

           // healthCanvas.transform.LookAt(Camera.main.transform);
          //  healthCanvas.transform.Rotate(0, 180, 0);
        //}
    }
}
