using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text minutes;
    public Text secundes;
    public Text dotteds;
    public int nowSec;
    public int nowMin;

    void Start()
    {
      int nowSec = int.Parse(secundes.text);
      StartCoroutine(start_timer());
    }

    IEnumerator start_timer()
    {
      while (true)
      {
        yield return new WaitForSeconds(1);
        if(nowSec >= 59)
        {
          nowSec = 0;
          secundes.text = nowSec.ToString(); 
          nowMin = nowMin + 1;
          minutes.text = nowMin.ToString();
        } else {
          nowSec = nowSec + 1;
          secundes.text = nowSec.ToString();   
        }
      }
    }
}
