using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//書いた人：みくみ なにかあったら言ってね

public class angryHumAddPointSc : MonoBehaviour
{
    public Text Scoretext;
    public int score = 0; //スコア変数


    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Seed")
        {
            /* ここよくわかんない
            //スコア処理を追加
            FindObjectOfType<ScoreManagerSc>().AddPoint(150);
            */

            Addpoint();
            

            //相手のタグがseedならば、自分を消す
            Destroy(this.gameObject);
        }
    }

    public void Addpoint()
    {
        score += 150;
        //テキストの表示を入れ替える
        Scoretext.text = "Score : " + score;

    }
}
