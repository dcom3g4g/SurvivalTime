using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Skill 
{
    // Start is called before the first frame update
    Rigidbody2D rigibody ;
    PlayerMove player;
    public float m_Speed = 5f;
    public Sword()
    {
        SkillDataStore skilldata = SkillDataStore.GetInstance();
        Level = skilldata.getSkillByName("Sword").Level1;
        Dame = skilldata.getSkillByName("Sword").Dame1[Level];
        Speed = skilldata.getSkillByName("Sword").Speed1[Level];
        Debug.Log(skilldata.getSkillByName("Sword").Level1); 
        
        
    }
    void Start()
    {
       rigibody = GetComponent<Rigidbody2D>();
       
       player = FindObjectOfType<PlayerMove>();
        //float x=0, y=0;
       rigibody.velocity = new Vector2(player.GetTruePosition().x*6,player.GetTruePosition().y*6);
    }
    
    // Update is called once per frame
    void Update()
    {
        
       
    }
}
