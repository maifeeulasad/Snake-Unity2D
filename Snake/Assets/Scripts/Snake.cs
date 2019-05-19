using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    public GameObject snakeCell;

    void Awake()
    {

        StartCoroutine(MoveSnake());
    }

    void LateUpdate()
    {
        
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

    IEnumerator MoveSnake()
    {
        while(true)
        {
            transform.GetChild(0).transform.position += Util.direction;
            int len = transform.childCount;
            for (int i = 1; i < len; i++)
            {
                transform.GetChild(i).transform.position = transform.GetChild(i - 1).transform.position;
            }
            yield return new WaitForSeconds(1f);

        }

    }

}
