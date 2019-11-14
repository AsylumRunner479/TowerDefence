using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Shop : MonoBehaviour
{
    public Vector2 scr;
    public static float money;
    public WaveManager wave;
    public TankManager tank;
    // Start is called before the first frame update
    void Start()
    {
        money = 100;
        
    }
    private void Update()
    {
       
    }
    // Update is called once per frame
    public void OnGUI()
    {
        scr = new Vector2(Screen.width / 16, Screen.height / 9);
        GUI.Button(new Rect(scr.x * 14.25f, scr.y * 0.5f, scr.x * 2, scr.y * 0.5f), "Money: " + money);
        GUI.Button(new Rect(scr.x * 1f, scr.y * 0.5f, scr.x * 2, scr.y * 0.5f), wave.enemySpawnCount + "/" + wave.maxEnemies);
        GUI.Button(new Rect(scr.x * 1f, scr.y * 1f, scr.x * 2, scr.y * 0.5f), "wave: " + TankManager.waveNumber + wave.waveNumber);
        //DisplayCustom();
        //DisplayStats();
    }
}
