using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject _wall_1;
    public GameObject _wall_2;
    public GameObject _wall_3;
    public GameObject _wall_4;
    public GameObject _wall_5;
    public GameObject _wall_6;
    public GameObject _wall_7;
    public GameObject _wall_8;


    void Start()
    {

        Physics.IgnoreCollision(_wall_1.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(_wall_2.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(_wall_3.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(_wall_4.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
