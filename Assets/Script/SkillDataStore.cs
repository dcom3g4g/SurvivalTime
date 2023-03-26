using System.Collections.Generic;
public class SkillDataStore 
{
    // Start is called before the first frame update
    SkillData[] Data= new SkillData[5];
    public static SkillDataStore _instance;
    public static SkillDataStore GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SkillDataStore();
        }
        return _instance;
    }

    SkillDataStore()
    {
        // Sword data 
        SkillData sword = new SkillData() ;
        sword.Name1 = "Sword"; 
        sword.Dame1= new int[]{ 50,50,70,70,100};
        sword.Speed1 = new int[] { 10, 10, 8, 8, 8 };
        sword.Des1 = new string[] {"Summon a sword to attack the enermy","Increase atk of sword",
            "Extra summon 1 sword to attack enermy ","Increase attack speed of sword","Increase atk of sword and sword can pass over 1 enermy" }; 
        sword.Level1 = 0;
        Data[0] = sword ;
        SkillData icenet = new SkillData();
        icenet.Name1 = "IceNet"; 
        icenet.Dame1 = new int[] { 10, 10, 10, 15, 100 };
        icenet.Speed1 = new int[] { 2, 2, 3, 3, 5 };
        icenet.Level1 = 0;
        icenet.Des1 = new string[] { "Summon a Icenet are to slow down enermy speed and cause a little dame to enermy",
                                     "Increase the area of Icenet",
                                     "Increase slow of Icenet",
                                     "Increase dame enermy taken ",
                                     "Increase the are of Icenet and dame to enermy"
        }; 
        Data[1] = icenet;

        SkillData earththorn = new SkillData();
        earththorn.Name1 = "EarthThorns"; 
        earththorn.Dame1 = new int[] { 20, 20, 30, 30, 40 };
        earththorn.Speed1 = new int[] { 20, 20, 20, 30, 30 };
        earththorn.Level1 = 0;
        earththorn.Des1 = new string[] { "Summon EarthThorn area to attack enermy when enermy move on it ",
                                         "Extra summon 1 EarthThorn to attack enermy",
                                         "Increase dame of EarthThorn ",
                                         "Increase time exist of EarthThorn ",
                                         "Increase dame of EarthThorn and Increase area of EarthThor",
                                         }; 
        Data[2] = earththorn;
    }
    public SkillData getSkillByName(string s)
    {
        if (s.Contains("Sword"))
        {
            return Data[0];
        }
        else if (s.Contains("IceNet"))
        {
            return Data[1]; 
        }
        else if (s.Contains("EarthThorns"))
        {
            return Data[2]; 
        }
        return new SkillData();
    }
    public List<string> GetSkillAvailble()
    {
        List<string> list = new List<string>();
        for (int i=0;i<3;i++)
        {
            if (Data[i].Level1<5)
                list.Add(Data[i].Name1);
        }
        return list; 
    }
}
