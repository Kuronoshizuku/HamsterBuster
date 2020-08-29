using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    //追加した
    //ボタンを押したときの処理
    public void PushButtonScore()
    {
        SceneManager.LoadScene("scorescene");
    }
    public void PushButtonStart()
    {
        SceneManager.LoadScene("MainGameScene");
    }
    public void PushButtonTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}