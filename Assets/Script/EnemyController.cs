using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Zombie ;
    Zombie AmountZombie;
    Vector2 Position= new Vector2(0,0) ; 
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        AmountZombie = FindObjectOfType<Zombie>();
        
        if (AmountZombie.GetAmount()<=100)
        {
            Position.x = Random.Range(-18, 19);
            Position.y = Random.Range(-22, 11);
                
            Instantiate(Zombie, new Vector2(Position.x, Position.y), Quaternion.identity);

            
            AmountZombie.SetAmount(AmountZombie.GetAmount()+1);
            
        }
    }
}
