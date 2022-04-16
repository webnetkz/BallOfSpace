using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
  public float speed = 3f;

  void Start()
  {
  }

  void FixedUpdate()
  {
    transform.Rotate( new Vector3(0, 0, speed * Time.deltaTime) );
  }
}

