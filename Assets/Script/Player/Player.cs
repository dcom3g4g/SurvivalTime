using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private static int HP=100;
    private static int Dame;
    private static int Speed;
    private static int Amor;
    private static int Exp;
    private static int Level;
    private static int ExpMax=500;
    private static bool Is_Stop=true; 
    public Slider healbar;
    public Slider Expbar;
    public GameObject UpdateBoard;
    public GameObject GameOver; 
    public Player()

    {
      
        
    }

    public bool Is_Stop1 { get => Is_Stop; set => Is_Stop = value; }
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
        Expbar.maxValue = ExpMax+Level*300;
        Expbar.value = Exp;
        if (Exp>=ExpMax)
        {
            Exp = Exp - ExpMax; 
            Level+=1;
            UpdateBoard.SetActive(true); 
            
            Debug.Log("Level ne "+Level);
            
            
        }
        if (HP<=0)
        {
            UpdateSkillController x= new UpdateSkillController();
            x.SetStopAll();
            x.ClearExp();
            Is_Stop1=false;
            GameOver.SetActive(true); 

        }
    }
}
