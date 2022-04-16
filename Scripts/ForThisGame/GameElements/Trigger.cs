using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
  private GameObject _obj;
  private bool check;

  void Start()
  {
    _obj = GetComponent<GameObject>();
  }

  // Если что-то попало в тригер
  void OnTriggerEnter(Collider collision)
  {
    check = true;
    GetComponent<SpinObject>().enabled = false; // Отключаем скрипт кручения
 }

  void FixedUpdate()
  {
    if(check)
    {
        transform.position = transform.position + new Vector3(0, 15f * Time.deltaTime, 0); // Поднимаем торус вверх
        StartCoroutine(RemoveTorus());
    }  
  }

  IEnumerator RemoveTorus()
  {
    yield return new WaitForSeconds(5f);
    Destroy(this);
  }
}
