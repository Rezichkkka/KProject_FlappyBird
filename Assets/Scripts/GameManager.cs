using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public LossWindow LossWindow;
  public static GameManager instance;

  private void Start()
  {
    instance = this;
  }

  public void RestartScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1;
  }

  public void LoadScene(int sceneNumber)
  {
    SceneManager.LoadScene(sceneNumber);
    Time.timeScale = 1;
  }
    
    

  public void Loss()
  {
    LossWindow.gameObject.SetActive(true);
    LossWindow.PlayerLoss();
    Time.timeScale = 0;
  }
}
