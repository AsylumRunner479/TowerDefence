using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public static bool isDead;
    public static float curHealth, maxHealth;
    public GameObject death;
   
    public GameObject healthCanvas;
    public Image healthBar;

    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 10000f;
        curHealth = maxHealth;
        //healthCanvas = GameObject.FindGameObjectWithTag(healthCanvas);
        healthBar = GameObject.FindGameObjectWithTag("healthBar").GetComponent<Image>();
        PlayerHandler.isDead = false;
        death.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((curHealth/maxHealth) != healthBar.fillAmount)
        {
            healthBar.fillAmount = (curHealth/maxHealth);
        }
        else if (curHealth == 0)
        {
            PlayerHandler.isDead = true;
           death.SetActive(true);
           

        }
        if (!Input.GetKeyDown(KeyCode.R))
        {
        }
        else
        {
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.buildIndex);
        }

        if (healthBar.fillAmount < 1 && healthBar.fillAmount > 0)
        {

            healthCanvas.transform.LookAt(Camera.main.transform);
            healthCanvas.transform.Rotate(0, 180, 0);
        }
    }
}
