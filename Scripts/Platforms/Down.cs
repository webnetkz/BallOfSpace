using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
      {
        _rb.useGravity = true;
      }
    }

}
