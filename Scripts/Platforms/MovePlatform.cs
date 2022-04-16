using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
  public float start = 0f;
  public float finish = 0f;
  public float speed = 3f;
  private bool forward = true;
  public char axis = 'z';

  void Update()
  {
    if(axis == 'z') {
      if(transform.position.z >= finish)
      {
        forward = false;
      } 
      else if (transform.position.z <= start)
      {
        forward = true;
      }
    } else if (axis == 'x') {
      if(transform.position.x >= start)
      {
        forward = false;
      } 
      else if (transform.position.x <= finish)
      {
        forward = true;
      }
    }
    
  }

  void FixedUpdate()
  {
    if(axis == 'z') {
      if(forward == true)
      {
        transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
      } else {
        transform.position = transform.position + new Vector3(0, 0, -speed * Time.deltaTime);
      }
    } else if (axis == 'x') {
      if(forward == true)
      {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
      } else {
        transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
      }
    }
  }
}
