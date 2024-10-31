using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class GameManager : MonoBehaviour
{
  public GameObject levelComplete;
  public PlayerMovement movement;
  public float Delay = 2f;
  private bool GameHasEnded;

  public void GameOver()
  {
    if (this.GameHasEnded)
      return;
    this.GameHasEnded = true;
    Debug.Log((object) "Game Over");
    this.Invoke("ManageScene", this.Delay);
  }

  public void ManageScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    this.movement.enabled = true;
  }

  public void CompleteLevel() => this.levelComplete.SetActive(true);
  
}
