using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class Menu : MonoBehaviour
{
  public void Play() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
