using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//書いた人: みくみ なんかよくわかんないけどテストシーンでは動いた

public class UInumScript : MonoBehaviour
{
    GameObject[] humster;

    public Text humsterNum;
    public Text CurrentHeight;
    public int CurrentHeight_num = 0;


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
        int counthum = GameObject.FindGameObjectsWithTag("humster").Length;
        humsterNum.text = (counthum.ToString() + "匹");

        int countheight = (GameObject.FindGameObjectsWithTag("building").Length * 3);  //1段の高さを3mにしたいので*3してみた
        CurrentHeight.text = (countheight.ToString() + "m");

    }
}
