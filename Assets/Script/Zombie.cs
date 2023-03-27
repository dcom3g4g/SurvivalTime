using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    // Start is called before the first frame update
    PlayerMove player;
    private static int Amount = 2;
    public GameObject exp;
    private Vector2 Position; 
    public int GetAmount()
    {
        return Amount;
    }
    public void SetAmount(int amount)
    {
       Amount = amount;
    }
    Zombie()
    {
        
        Hp = 100; 
        Speed = 10;
        Level = 1;
        Dame = 10;
        
        Is_Stop = false;
    }
   
    void Start()
    {
        player = FindObjectOfType<PlayerMove>();
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigibody.velocity = new Vector2(-player.GetPositionOfPlayer().x/transform.position.x*5,- player.GetPositionOfPlayer().y / transform.position.y*5);
        Position = transform.position; 
        transform.position = Vector3.MoveTowards(transform.position, player.GetPositionOfPlayer(), (float)Speed/10000f);

    }
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        
    }
private void OnDestroy()
    {
        Amount--; 
        Instantiate(exp,Position,Quaternion.identity);
    }

}
