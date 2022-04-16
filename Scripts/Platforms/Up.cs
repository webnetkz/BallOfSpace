using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
  public float range;
  public float speed;
  private bool up = true;

  void Update()
  {
    if(transform.position.y >= range)
    {
      up = false;
    } 
    else if (transform.position.y <= -2f)
    {
      up = true;
    }
  }

  void FixedUpdate()
  {
    if(up == true)
    {
      transform.position = transform.position + new Vector3(0, range * speed * Time.deltaTime, 0);
    } else {
      transform.position = transform.position + new Vector3(0, -range * speed * Time.deltaTime, 0);
    }
  }
}
