using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    protected int Hp = 1; 
    protected static int Dame = 0;
    protected static int Level = 0;
    protected int Speed = 0;
    private bool is_Slow = false;
    protected bool Is_Die = false;
    protected static bool Is_Stop = true;
    protected new Rigidbody2D rigibody;
    protected static SkillController SkillController=new SkillController();
    private float time = 0;
    private int timeAll = 0;
    PlayerMove player;
    Player pl=new Player(); 
    public bool Is_Slow { get => is_Slow; set => is_Slow = value; }

    void Start()
    {
        rigibody = gameObject.GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMove>();
        //rigibody = this.gameObject.GetComponent<rigibody2D>();
    }
    public bool IsStop()
    {
        return Is_Stop;
    }
    public void SetIsStop(bool Stop)
    {
        Is_Stop = Stop;
    }
    public bool IsDie()
    {
        return Is_Die;
    }
    public void SetIsDie(bool Die)
    {
        Is_Die = Die;
    }
    public int GetDame()
    {
        return Dame;
    }
    public void SetDame(int dame)
    {
        Dame = dame;
    }
    public int GetLevel()
    {
        return Level;
    }
    public void SetLevel(int lv)
    {
        Level = lv;
    }
    public int GetSpeed()
    {
        return Speed;
    }
    public void SetSpeed(int sp)
    {
        this.Speed = sp;
    }
    public int GetHp()
    {
        return Hp;
    }
    public void SetHP(int hp)
    {
        Hp = hp;
    }
   

    // Update is called once per n 
    void Update()
    {
        rigibody.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.tag == "Skill")
        {
            if (collisionData.gameObject.name.ToString().Contains("Sword"))
            {
                this.Hp -= SkillController.GetDameOfSkillByName(collisionData.gameObject.name.ToString());
                Destroy(collisionData.gameObject);
                
                if (this.Hp <= 0)
                {
                    SetIsDie(true);

                    Destroy(gameObject);
                }
            }

        }
        if (collisionData.gameObject.tag == "Player")
        {
            pl.HP1 -= 10;
            Debug.Log(pl.HP1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.ToString().Contains("IceNet"))
        {
            if (!this.is_Slow)
            {
                this.Speed = this.Speed * 3 / 10;
                this.Is_Slow = true;
            }
        }
        time += Time.deltaTime;
        if (time >= 0.1f)
        {

            timeAll += 1;
            if (collision.gameObject.name.ToString().Contains("EarthThorn"))
            {

                if (timeAll % (SkillController.GetSpeedOfSkillByName(collision.gameObject.name.ToString()) / 2) == 0)
                {
                    this.Hp -= SkillController.GetDameOfSkillByName(collision.gameObject.name.ToString());

                    if (this.Hp <= 0)
                    {
                        SetIsDie(true);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.ToString().Contains("IceNet"))
        {
            if (this.is_Slow)
            {
                this.Speed = this.Speed * 10 / 3;
                this.Is_Slow = false;
            }
        }
    }

    
}
