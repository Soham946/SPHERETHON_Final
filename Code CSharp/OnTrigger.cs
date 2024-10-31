using UnityEngine;

#nullable disable
public class OnTrigger : MonoBehaviour
{
  public GameManager gameManager;

  private void OnTriggerEnter() => this.gameManager.CompleteLevel();
}
