using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
  public Button playButton;
  public Button quitButton;

  private Button[] buttons;
  private int currentIndex = 0;

  void Start()
  {
    buttons = new Button[] {playButton, quitButton};
    SelectButton(currentIndex);
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      currentIndex = (currentIndex + 1) % buttons.Length;
      SelectButton(currentIndex);
    }

    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
      currentIndex = (currentIndex - 1 + buttons.Length) % buttons.Length;
      SelectButton(currentIndex);
    }

     if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
     {
      buttons[currentIndex].onClick.Invoke();
     }
  }

  void SelectButton(int index)
  {
    EventSystem.current.SetSelectedGameObject(buttons[index].gameObject);
  }
  public void Play ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void Quit()
  {
    Application.Quit();
    Debug.Log("Player Has Quit The Game");
  }


}
