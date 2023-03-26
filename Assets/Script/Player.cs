using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private static int HP;
    private static int Dame;
    private static int Speed;
    private static int Amor;
    private static int Exp;
    private static int Level;
    public Slider healbar; 
    public Player()
    {
        HP = 100;
        Dame = 10;
        Speed = 10;
        Amor = 10;
        Exp = 0; 
        Level = 0;
        
    }
    public int HP1 { get => HP; set => HP = value; }
    public int Dame1 { get => Dame; set => Dame = value; }
    public int Speed1 { get => Speed; set => Speed = value; }
    public int Amor1 { get => Amor; set => Amor = value; }
    public int Exp1 { get => Exp; set => Exp = value; }
    public int Level1 { get => Level; set => Level = value; }

    void Start()
    {
        healbar.maxValue = HP;
        healbar.value = HP;
    }

    // Update is called once per frame
    void Update()
    {
        healbar.value = HP; 
    }
}
