using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    public GameObject snakeCell;
    List<GameObject> cells = new List<GameObject>();

    
    
    void LateUpdate()
    {
        foreach(Transform child in transform)
        {
            cells.Add(child.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.W) && Util.direction!=Util.down)
        {
            Util.direction = Util.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && Util.direction != Util.up)
        {
            Util.direction = Util.down;
        }
        else if (Input.GetKeyDown(KeyCode.A) && Util.direction != Util.right)
        {
            Util.direction = Util.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && Util.direction != Util.left)
        {
            Util.direction = Util.right;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }

}
