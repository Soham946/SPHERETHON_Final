using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Score : MonoBehaviour
{
  public Transform player;
  public Text scoreText;

  private void Update() => this.scoreText.text = (this.player.position.z / 2f).ToString("0");
}
