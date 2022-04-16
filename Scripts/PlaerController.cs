using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody _rb;
    private float horizontal;
    private float vertical;
    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        move = new Vector3(horizontal, 0, vertical);
    }

    void FixedUpdate()
    {
        _rb.AddForce(move * speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
