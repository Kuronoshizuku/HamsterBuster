using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameSysten : MonoBehaviour
{

  //スタートボタンを押したら実行する
  public void StartGame() {
        SceneManager.LoadScene("Game");
    }
}
