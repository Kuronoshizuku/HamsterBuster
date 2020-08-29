using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//書いた人: みくみ なんかよくわかんないけどテストシーンでは動いた

public class UInumScript : MonoBehaviour
{
    GameObject[] humster;

    public Text Scoretext;
    int Score; //スコア変数
    public Text humsterNum;
    public Text CurrentHeight;
    public Text SeedNum;
    public int CurrentHeight_num = 0;
    public int counthum;
    public int Shotcount;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    void Check()
    {
        int Shotcount = HimawarinotaneShooter.shotCount;
        SeedNum.text = (Shotcount.ToString() + "粒");

        int counthum = GameObject.FindGameObjectsWithTag("humster").Length;
        humsterNum.text = (counthum.ToString() + "匹");

        int countheight = (GameObject.FindGameObjectsWithTag("building").Length * 3);  //1段の高さを3mにしたいので*3してみた
        CurrentHeight.text = (countheight.ToString() + "m");

        //テキストの表示を入れ替える
        Score = seedDestroyer.score;
        Scoretext.text = (Score.ToString()+"/30 匹");

        if(Score > 30)
        {
            StartCoroutine(timer());
        }

    }

    IEnumerator timer()
    {
        text.GetComponent<Text>().color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("HamuClearGame");
    }


}
