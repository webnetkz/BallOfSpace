using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantom : MonoBehaviour
{

public GameObject MainCamera; //аттач главной камеры для получения вектора направления движения
public GameObject Player; //Объект игрок

public float jumpForce;
 
public float speed; //Скорость перемещения
private Rigidbody rb; //Физическое тело
private bool grounded; // На земле ли персонаж?
private bool moveForward; // Двигается вперед персонаж?
private bool moveBack; // Двигается назад персонаж?
private bool moveRight; // Двигается право персонаж?
private bool moveLeft; // Двигается влево персонаж?

private bool isJumped = false;
 
//Задаем переменные при старте игры
void Start()
{
  grounded = false;
  rb = Player.GetComponent<Rigidbody>();
  moveForward = false;
  moveBack = false;
  moveRight = false;
  moveLeft = false;
}
 
 
void OnTriggerEnter (Collider other) {
  if (other.tag == "Floor")
  {
    grounded = true;
  }
}
void OnTriggerStay (Collider other) {
  if (other.tag == "Floor")
  {
    grounded = true;
  }
}
void OnTriggerExit (Collider other) {
  if (other.tag == "Floor")
  {
    grounded = false;
  }
}

void Update()
{

  if(Input.GetAxis("Vertical") > 0.0f & grounded == true) // Движение вперед
  {
    moveForward = true;
  } else {
    moveForward = false;
  }

  if(Input.GetAxis("Vertical") < 0.0f & grounded == true) // Движение назад
  {
    moveBack = true;
  } else {
    moveBack = false;
  }

  if(Input.GetAxis("Horizontal") > 0.0f & grounded == true) // Движение в лево
  {
    moveLeft = true;
  } else {
    moveLeft = false;
  }

  if(Input.GetAxis("Horizontal") < 0.0f & grounded == true) // Движение в право
  {
    moveRight= true;
  } else {
    moveRight = false;
  }

  // Проверка для прыжка
  if(Input.GetKeyDown(KeyCode.Space) & grounded == true)
  {
    isJumped = true;
  }
}
 
void FixedUpdate()
{
  if(isJumped == true)
  {
    rb.AddForce(new Vector3(0f, jumpForce, 0f));
    isJumped = false;
  }

  if(moveForward)
  {
    rb.AddForce(MainCamera.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
  }

  if(moveBack)
  {
    rb.AddForce(-MainCamera.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
  }

  if(moveLeft)
  {
    rb.AddForce(MainCamera.transform.right * speed * Time.deltaTime, ForceMode.Impulse);
  }

  if(moveRight)
  {
    rb.AddForce(-MainCamera.transform.right * speed * Time.deltaTime, ForceMode.Impulse);
  }
}
     
}
