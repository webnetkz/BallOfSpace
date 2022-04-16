using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public Rigidbody _rb;


    // Update is called once per frame
    void Update()
    {
        if (_rb.transform.position.y < -10f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
