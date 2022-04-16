using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpHeight;

    private Rigidbody _rb;
    private bool isJumped = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isJumped == false)
        {
            _rb.AddForce(0, jumpHeight, 0);
            isJumped = true;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        isJumped = false;
    }
}
