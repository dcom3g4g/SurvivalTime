using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthThorns : Skill
{
    // Start is called before the first frame update
    float TimeAlive = 0;
    float time = 0;
    float Area = 0; 
    public EarthThorns()
    {
        
        SkillDataStore skilldata = SkillDataStore.GetInstance();
        TimeAlive = 2+ skilldata.getSkillByName("EarthThorns").Level1%4;
        Level = skilldata.getSkillByName("EarthThorns").Level1;
        Dame = skilldata.getSkillByName("EarthThorns").Dame1[Level];
        Speed = skilldata.getSkillByName("EarthThorns").Speed1[Level];
        Area = 0.4f ;
    }
    void Start()
    {
        if (Level<4)
            gameObject.transform.localScale= new Vector3 (Area,Area,Area);
        else
            gameObject.transform.localScale = new Vector3(0.5f,0.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2)
            Destroy(gameObject); 
    }
}
