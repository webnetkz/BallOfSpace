using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject _obj;
    public Text counterText;
    public GameObject _restart;

    private int count;
    private int tmpCount;

    void Start()
    {
        count = _obj.transform.childCount;
        counterText.text = count.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Torus")
        {
            tmpCount = int.Parse(counterText.text) - 1;
            counterText.text = tmpCount.ToString();
            if(tmpCount == 0)
            {
              Application.Quit();
                //_restart.SetActive(true);
            }
        }
    }
}
