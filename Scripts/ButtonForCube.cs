using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForCube : MonoBehaviour
{
  public string cubeTag;

  void OnTriggerEnter(Collider collision)
  {
    Debug.Log(collision);
  }
}
