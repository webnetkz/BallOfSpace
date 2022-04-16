using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
