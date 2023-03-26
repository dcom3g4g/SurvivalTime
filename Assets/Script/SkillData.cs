using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillData
{
    private string Name; 
    private int[] Dame;
    private int Level;
    private int[] Speed;
    private string[] Des; 
    public SkillData()
    {

    }
    public SkillData(string name, int[] dame, int level, int[] speed)
    {
        Name = name;
        Dame = dame;
        Level = level;
        Speed = speed;
    }

    public string Name1 { get => Name; set => Name = value; }
    public int[] Dame1 { get => Dame; set => Dame = value; }
    public int Level1 { get => Level; set => Level = value; }
    public int[] Speed1 { get => Speed; set => Speed = value; }
    public string[] Des1 { get => Des; set => Des = value; }
}
