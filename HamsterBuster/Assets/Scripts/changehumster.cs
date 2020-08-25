using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changehumster : MonoBehaviour
{
    Material[] Prefabs;


    // Use this for initialization
    void Start()
    {

        //Resourcesフォルダからマテリアルを読み込む
        Prefabs = Resources.LoadAll<Material>("Prefabs/");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        //"humster"タグが付いているオブジェクトのマテリアルを変更する
        if (collision.gameObject.tag == "humster")
        {
            //オブジェクトのマテリアルを変更する
            gameObject.GetComponent<Renderer>().material = Prefabs[0];
            collision.gameObject.GetComponent<Renderer>().material = Prefabs[1];
            collision.gameObject.GetComponent<Renderer>().material = Prefabs[2];
        }

    }

}