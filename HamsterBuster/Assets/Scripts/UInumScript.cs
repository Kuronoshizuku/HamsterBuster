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
    public static int score = 0; //スコア変数
    public Text humsterNum;
    public Text CurrentHeight;
    public Text SeedNum;
    public int CurrentHeight_num = 0;
    public int counthum;
    public int countSeed;
    public int Shotcount = HimawarinotaneShooter.shotCount;



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
        int countSeed = (Shotcount - GameObject.FindGameObjectsWithTag("seed").Length);
        SeedNum.text = (countSeed.ToString() + "粒");

        int counthum = GameObject.FindGameObjectsWithTag("humster").Length;
        humsterNum.text = (counthum.ToString() + "匹");

        int countheight = (GameObject.FindGameObjectsWithTag("building").Length * 3);  //1段の高さを3mにしたいので*3してみた
        CurrentHeight.text = (countheight.ToString() + "m");

        //テキストの表示を入れ替える
        Scoretext.text = score.ToString();

        if(score > 500)
        {
            ChangeClearScene();
        }

    }

    IEnumerator clear()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameClearScene");
    }

    void ChangeClearScene()
    {

            StartCoroutine(clear());
    }

}
