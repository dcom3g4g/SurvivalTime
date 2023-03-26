using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSkillController : MonoBehaviour
{ 
    // Start is called before the first frame update
    public Text skilldes1,skilldes2,skilldes3;
    public Sprite Sword, EarthThorn, IceNet;
    public Image SkillUpdate1, SkillUpdate2, SkillUpdate3; 
    SkillDataStore skilldata = SkillDataStore.GetInstance();
    SkillData skill3, skill2, skill1; 
    void Start()
    {
        List<string> list = skilldata.GetSkillAvailble();

        skill1 = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        skill2 = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        skill3 = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        string[] listskill = new string[] { skill1.Name1,skill2.Name1,skill3.Name1 };
        
        if (skill1.Name1.Contains("Sword"))
        {
            SkillUpdate1.sprite = Sword;
            
        }
        if (skill2.Name1.Contains("Sword"))
        {
            SkillUpdate2.sprite = Sword;
        }
        if (skill3.Name1.Contains("Sword"))
        {
            SkillUpdate3.sprite = Sword;
        }

        if (skill1.Name1.Contains("EarthThorns"))
        {
            SkillUpdate1.sprite = EarthThorn;
        }
        if (skill2.Name1.Contains("EarthThorns"))
        {
            SkillUpdate2.sprite = EarthThorn;
        }
        if (skill3.Name1.Contains("EarthThorns"))
        {
            SkillUpdate3.sprite = EarthThorn;
        }

        if (skill1.Name1.Contains("IceNet"))
        {
            SkillUpdate1.sprite = IceNet;
        }
        if (skill2.Name1.Contains("IceNet"))
        {
            SkillUpdate2.sprite = IceNet;
        }
        if (skill3.Name1.Contains("IceNet"))
        {
            SkillUpdate3.sprite = IceNet;
        }
        skilldes1.text = skill1.Des1[skill1.Level1 + 1];
        skilldes2.text = skill2.Des1[skill2.Level1 + 1];
        skilldes3.text = skill3.Des1[skill3.Level1 + 1];
        //img2.sprite = (Sprite)Resources.Load("Assets/Sprite/Earththorns.png");
        //img3.sprite = (Sprite)Resources.Load("Assets/Sprite/Earththorns.png");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
