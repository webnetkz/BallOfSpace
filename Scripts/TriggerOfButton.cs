using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOfButton : MonoBehaviour
{
    public GameObject _go;

    void OnTriggerEnter(Collider other)
    {
      if(other.tag == "RedCube")
      {
        _go.GetComponent<MovePlatform>().enabled = true;
      }
    }
}
