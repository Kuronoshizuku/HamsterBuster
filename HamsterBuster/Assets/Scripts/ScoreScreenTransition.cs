using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScreenTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    //追加した
    //ボタンを押したときの処理
    public void PushButton()
    {
        SceneManager.LoadScene("scorescene");
    }
}