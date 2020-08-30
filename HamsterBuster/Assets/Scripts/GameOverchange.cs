using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//書いた人 みくみ
//なぜかボタンが反応しないので12秒立つと強制的にタイトルに飛ばすようにしました。

public class GameOverchange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("TitleScene");

    }
}
