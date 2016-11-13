using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

public class Menu : MonoBehaviour {

     public GameObject menuPanel;
     public void PauseGame() {
          menuPanel.SetActive(true);
          Time.timeScale=0;
     }
     public void StartGame() {
          menuPanel.SetActive(false);
          Time.timeScale=1;
     }
     public void RestartGame() {
          SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
          StartGame();/////
     }
     public void QuitGame() {
          Application.Quit();
     }
}
