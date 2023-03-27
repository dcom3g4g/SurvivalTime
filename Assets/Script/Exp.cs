using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerMove player;
    Player pl=new Player(); 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player= FindObjectOfType<PlayerMove>();
        if ((player.GetPositionOfPlayer()-transform.position).sqrMagnitude<0.3)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.GetPositionOfPlayer(), 0.03f);
        }
    }
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        // If a GameObject has an "Enemy" tag, remove him.
        if (collisionData.gameObject.tag == "Player")
        {
            pl.Exp1 += 50; 
            Destroy(gameObject); 
            

        }
    }
}
