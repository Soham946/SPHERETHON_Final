// Decompiled with JetBrains decompiler
// Type: LevelDone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 780DBB25-BB68-4FE2-973C-96798C2C1AC6
// Assembly location: H:\BACKUP\DOCUMENTS\SPHERETHON\SPHERETHON_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class LevelDone : MonoBehaviour
{
  public void LoadNextLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
