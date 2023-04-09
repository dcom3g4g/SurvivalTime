using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSkillController : MonoBehaviour
{ 
    // Start is called before the first frame update
    public Text skilldes1,skilldes2,skilldes3;
    public Sprite Sword, EarthThorn, IceNet;
    public Image[] SkillUpdate;
    int i = 0;
    public Button Selectskill, Selectskill1, Selectskill2;
    SkillDataStore skilldata = SkillDataStore.GetInstance();
    SkillData[] skill; 
    void Start()
    {

    }
    private void OnEnable()
    {
        Debug.Log("i ne +" + i);
        i++;

        SetStopAll();

        List<string> list = skilldata.GetSkillAvailble();
        skill = new SkillData[3];
        skill[0] = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        skill[1] = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        skill[2] = skilldata.getSkillByName(list[Random.Range(0, list.Count)]);
        string[] listskill = new string[] { skill[0].Name1, skill[1].Name1, skill[2].Name1 };
        for (int i = 0; i < 3; i++)
        {
            if (skill[i].Name1.Contains("Sword"))
            {
                SkillUpdate[i].sprite = Sword;
            }
            if (skill[i].Name1.Contains("EarthThorns"))
            {
                SkillUpdate[i].sprite = EarthThorn;
            }
            if (skill[i].Name1.Contains("IceNet"))
            {
                SkillUpdate[i].sprite = IceNet;
            }
        }
        Enemy enemy = new Enemy();
        Skill skil = new Skill();
        Player player = new Player();
        enemy.SetIsStop(true);
        skil.SetIsStop(true);
        player.Is_Stop1 = true;
        skilldes1.text = skill[0].Des1[skill[0].Level1 + 1];
        skilldes2.text = skill[1].Des1[skill[1].Level1 + 1];
        skilldes3.text = skill[2].Des1[skill[2].Level1 + 1];
        if (i == 1)
        {
            Selectskill.onClick.AddListener(delegate () { this.UpdateSkill(skill[0].Name1); });
            Selectskill1.onClick.AddListener(delegate () { this.UpdateSkill(skill[1].Name1); });
            Selectskill2.onClick.AddListener(delegate () { this.UpdateSkill(skill[2].Name1); });
        }
    }
    
    public void SetStopAll()

    {
        Enemy enemy = new Enemy();
        Skill skil = new Skill();
        Player player = new Player();
        enemy.SetIsStop(true);
        skil.SetIsStop(true);
        player.Is_Stop1 = true;
    }
    public void ClearExp()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Exp");
        foreach (GameObject go in gos)
        {
            Destroy(go);
        }
    }
    void UpdateSkill(string name)
    {
        gameObject.SetActive(false);
        Enemy enemy = new Enemy();
        Skill skil = new Skill();
        Player player = new Player();
        enemy.SetIsStop(false);
        skil.SetIsStop(false);
        player.Is_Stop1 = false;
        Debug.Log(name + skilldata.getSkillByName(name).Level1);
        skilldata.getSkillByName(name).Level1 += 1;
        Debug.Log(name + skilldata.getSkillByName(name).Level1);
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Check()
    {

    }
}
