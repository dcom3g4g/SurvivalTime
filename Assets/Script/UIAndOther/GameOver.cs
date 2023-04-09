using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Button playAgain, Back;
    Zombie zb; 
    Player player= new Player();
    void Start()
    {
        playAgain.onClick.AddListener(delegate () { this.PlayAgain(); });
        Back.onClick.AddListener(delegate () { this.BackHome(); });
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayAgain()
    {
        zb = FindObjectOfType<Zombie>();
        zb.SetAmount(1); 
        gameObject.SetActive(false);
        Application.LoadLevel("PlaySence");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.HP1 = 100; 
    }
    void BackHome()
    {
        zb = FindObjectOfType<Zombie>();
        zb.SetAmount(1);
        gameObject.SetActive(false);
        Application.LoadLevel("StartSence");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.HP1 = 100; 
    }
}
