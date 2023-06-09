using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceNet : Skill
{

    public IceNet()
    {
        SkillDataStore skilldata = SkillDataStore.GetInstance();
        Level = skilldata.getSkillByName("IceNet").Level1;
        Dame = skilldata.getSkillByName("IceNet").Dame1[Level];
        Speed = skilldata.getSkillByName("IceNet").Speed1[Level];
        

    }
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        // If a GameObject has an "Enemy" tag, remove him.
        if (collisionData.gameObject.tag == "Enemy")
        {
            

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Level<4)
            gameObject.transform.localScale= new Vector3(3,3,3);
        else
            gameObject.transform.localScale = new Vector3(5, 5, 3);
    }
}
