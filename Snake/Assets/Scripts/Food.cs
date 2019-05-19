using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }


}
