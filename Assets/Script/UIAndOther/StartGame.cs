using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Startbt; 
    void Start()
    {
        Startbt.onClick.AddListener(delegate () { this.PlayGame(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayGame()
    {
        Application.LoadLevel("PlaySence"); 
    }
    void PlayGame1()
    {

    }
}
