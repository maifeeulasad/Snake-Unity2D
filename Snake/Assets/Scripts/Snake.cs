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
        if(Input.GetKeyDown(KeyCode.W))
        {
            cells[0].transform.position
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Equals("food"))
        {
            Destroy(collision.collider.gameObject);
        }
    }

}
