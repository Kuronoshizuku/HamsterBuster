using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIの追加

public class ScoreManagerSc : MonoBehaviour
{
    public GameObject score_object = null; //textオブジェクト
    public int score_num = 0; //スコア変数


    //初期化
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //テキストの表示を入れ替える
        score_text.text = "Score : " + score_num;
        
        score_num += 1; //とりあえず１加算し続ける

        
    }
}
