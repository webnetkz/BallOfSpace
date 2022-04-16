using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

  [SerializeField] private GameObject mainMenu;

  void Start()
  {
    Debug.Log(mainMenu);
  }
  public void Pause()
  {
    mainMenu.SetActive(true);
    Time.timeScale = 0;
  }

  public void Continue()
  {
    mainMenu.SetActive(false);
    Time.timeScale = 1;
  }

  public void ExitApp()
  {
    Application.Quit();
  }
}