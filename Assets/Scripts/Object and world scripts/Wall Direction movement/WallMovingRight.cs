using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovingRight : MonoBehaviour
{
    public float Speed = 2f;


    void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;
    }
}
