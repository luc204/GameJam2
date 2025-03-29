using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofMovingDown : MonoBehaviour
{

    public float Speed = 2f;
    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;
    }
}
