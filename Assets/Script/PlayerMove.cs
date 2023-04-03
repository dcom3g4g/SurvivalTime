using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    protected Joystick joystick;
    protected JoyButton joyButton;
    protected new Rigidbody2D rigidbody;
    public Object player;
    Player pl = new Player(); 
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>(); 
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pl.Is_Stop1)
        {
            if (rigidbody.position.x >= 24.0)
                rigidbody.velocity = new Vector2(-1 * 1f, 0);
            else if (rigidbody.position.x <= -27.4)
                rigidbody.velocity = new Vector2(1 * 1f, 0);
            else if (rigidbody.position.y >= 16.6)
                rigidbody.velocity = new Vector2(0, -1 * 1f);
            else if (rigidbody.position.y <= -13.9)
                rigidbody.velocity = new Vector2(0, 1 * 1f);
            else
                rigidbody.velocity = new Vector2(joystick.Horizontal * 4f, joystick.Vertical * 4f);
        }
        else
        {
            rigidbody.velocity = Vector2.zero;
        }
        
    }
    public float GetJoyStickHorizontal()
    {
        if (joystick == null || joystick.Horizontal == 0)
            return 0;
        return joystick.Horizontal;
    }
    public float GetJoyStickVertical()
    {
        if (joystick == null || joystick.Vertical == 0)
            return 0;
        return joystick.Vertical;
    }
    public Vector3 GetPositionOfPlayer()
    {
        return transform.position;    
    }
    public Vector3 GetClosestEnemyPosition()
    {
        List<Vector3> result= new List<Vector3>(); 
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        GameObject closest1 = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest1 = closest; 
                closest = go;
                distance = curDistance;
            }
        }
        
        return closest.transform.position;
    }
    public Vector3 GetSecondClosestEnemyPosition(Vector3 pos)
    {
        List<Vector3> result = new List<Vector3>();
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        GameObject closest1 = null;
        float distance = Mathf.Infinity;
        Vector3 position = pos;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && curDistance!=0)
            {
                closest1 = closest;
                closest = go;
                distance = curDistance;
            }
        }

        return closest.transform.position;
    }
    public GameObject GetClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    public Vector2 GetTruePosition()
    {
        Vector2 PointA = GetPositionOfPlayer();
        Vector2 PointC = GetClosestEnemyPosition();
        float R = Mathf.Sqrt(Mathf.Pow(PointA.x - PointC.x, 2) + Mathf.Pow(PointA.y - PointC.y, 2)); 
        float x= Mathf.Sqrt(Mathf.Pow(PointA.x - PointC.x, 2) + Mathf.Pow(PointC.y - PointC.y, 2));
        float y = Mathf.Sqrt(Mathf.Pow(PointC.x - PointC.x, 2) + Mathf.Pow(PointA.y - PointC.y, 2));
        if ((PointC.x<=PointA.x) && (PointC.y>=PointA.y))
            return new Vector2(-x/R, y/R);
        if (PointC.x <= PointA.x && PointC.y <= PointA.y)
            return new Vector2(-x / R, -y / R);
        if (PointC.x >= PointA.x && PointC.y <= PointA.y)
            return new Vector2(x / R, -y / R);
        if (PointC.x >= PointA.x && PointC.y >= PointA.y)
            return new Vector2(x / R, y / R);
        return new Vector2(0, 0);
    }
    
}
