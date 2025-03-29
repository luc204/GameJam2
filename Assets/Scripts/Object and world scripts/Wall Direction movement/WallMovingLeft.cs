using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovingLeft : MonoBehaviour
{
    public float Speed = 2f;

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
