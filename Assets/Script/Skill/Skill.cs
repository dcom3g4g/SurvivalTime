using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    // Start is called before the first frame update
    protected int Dame = 0;
    protected int Level = 0;
    protected int Speed = 0;
    protected static bool Is_Stop = true;
 
    public void Start()
    {
        
    }
    public bool IsStop()
    {
        return Is_Stop;
    }
    public void SetIsStop(bool Stop)
    {
        Is_Stop = Stop;
    }
    public int GetDame()
    {
        return Dame;
    }
    public void SetDame(int dame)
    {
        Dame = dame; 
    }
    public int GetLevel()
    {
        return Level;
    }
    public void SetLevel(int lv)
    {
        Level = lv;
    }
    public int GetSpeed()
    {
        return Speed;
    }
    public void SetSpeed(int sp)
    {
        Speed = sp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
