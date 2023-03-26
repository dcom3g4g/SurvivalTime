using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthThorns : Skill
{
    // Start is called before the first frame update
    float TimeAlive = 0;
    float time = 0; 
    public EarthThorns()
    {
        TimeAlive = 2;
        SkillDataStore skilldata = SkillDataStore.GetInstance();
        Level = skilldata.getSkillByName("EarthThorns").Level1;
        Dame = skilldata.getSkillByName("EarthThorns").Dame1[Level];
        Speed = skilldata.getSkillByName("EarthThorns").Speed1[Level];
        
        Is_Stop = false;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2)
            Destroy(gameObject); 
    }
}
