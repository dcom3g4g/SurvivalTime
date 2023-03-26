using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    // Start is called before the first frame update
    private int[] Weapon;
    private float time =0 ;
    private int timeAll = 0; 
    public GameObject sword ;
    public GameObject EarthThorn; 
    PlayerMove player;
    Sword sw = new Sword();
    EarthThorns et = new EarthThorns(); 
    void Start()
    {
        Weapon = new int[10];
        player = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
       time+=Time.deltaTime;
        if (time >= 0.1f)
        {
            Vector2 Position = new Vector2(player.GetPositionOfPlayer().x, player.GetPositionOfPlayer().y);
            timeAll += 1; 
            if (timeAll%sw.GetSpeed()==0)
            {
                
                float Degree = (Mathf.Acos(player.GetTruePosition().y) * 180 / Mathf.PI);
                // Sword ---------------
                if (sw.GetLevel() == 1)
                {
                    if (player.GetPositionOfPlayer().x < player.GetClosestEnemyPosition().x)
                        Instantiate(sword, Position, Quaternion.Euler(-Vector3.forward * Degree));
                    else
                        Instantiate(sword, Position, Quaternion.Euler(Vector3.forward * Degree));
                }
                
                else if ( sw.GetLevel()==3)
                {
                    
                    if (player.GetPositionOfPlayer().x < player.GetClosestEnemyPosition().x)
                    {
                        Instantiate(sword, Position, Quaternion.Euler(-Vector3.forward * Degree));
                        Instantiate(sword, new Vector2(Position.x-0.1f,Position.y - 0.1f), Quaternion.Euler(-Vector3.forward * Degree));
                    }
                    else
                    {
                        Instantiate(sword, Position, Quaternion.Euler(Vector3.forward * Degree));
                        Instantiate(sword, new Vector2(Position.x - 0.1f, Position.y - 0.1f), Quaternion.Euler(Vector3.forward * Degree));
                    }
                    Debug.Log(System.DateTime.Now);
                }
                // Sword ----------------
                
                
            }
            //---------------------------------------------------
            // EarthThorn -----------
            if (timeAll % et.GetSpeed() == 0)
            {

                if (et.GetLevel() == 1)
                {
                    int x = 0, y = 0;
                    Instantiate(EarthThorn, player.GetClosestEnemyPosition(), Quaternion.identity);
                }
            }
            time = 0f;
        }
    }
    public int GetDameOfSkillByName(string x)
    {
        if (x.CompareTo("Sword(Clone)")==0)
        {
            return sw.GetDame();
            
        }
        if (x.Contains("EarthThorn"))
        {
            return et.GetDame();
        }
        return 0;
    }
    public int GetSpeedOfSkillByName(string x)
    {
        if (x.Contains("EarthThorn"))
        {
            return et.GetSpeed();
        }
        return 0;
    }
    
    public void IncreaseSkillLevel(int weaponindex)
    {
        Weapon[weaponindex] ++;
    }
    
}
