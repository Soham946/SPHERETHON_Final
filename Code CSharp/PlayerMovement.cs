using UnityEngine;

#nullable disable
public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  public float ForwardForce = 2000f;
  public float SidewayForce = 500f;

  private void FixedUpdate()
  {
    this.rb.AddForce(0.0f, 0.0f, this.ForwardForce * Time.deltaTime, ForceMode.VelocityChange);
    if (Input.GetKey("d"))
      this.rb.AddForce(this.SidewayForce * Time.deltaTime, 0.0f, 0.0f, ForceMode.VelocityChange);
    if (Input.GetKey("a"))
      this.rb.AddForce(-this.SidewayForce * Time.deltaTime, 0.0f, 0.0f, ForceMode.VelocityChange);
    if ((double) this.rb.position.y >= -25.0)
      return;
    Object.FindObjectOfType<GameManager>.GameOver();
  }
}
