using UnityEngine;

#nullable disable
public class OnCollision : MonoBehaviour
{
  public PlayerMovement movement;

  private void OnCollisionEnter(Collision collisionInfo)
  {
    if (!(collisionInfo.collider.tag == "Obstacle"))
      return;
    this.movement.enabled = false;
    Object.FindObjectOfType<GameManager>().GameOver();
  }
}
