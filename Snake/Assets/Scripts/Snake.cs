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
        if (Input.GetKeyDown(KeyCode.W))
        {
            cells[0].transform.position += Util.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            cells[0].transform.position += Util.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            cells[0].transform.position += Util.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            cells[0].transform.position += Util.right;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }

}
