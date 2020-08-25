using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarControllerSc : MonoBehaviour
{
    public int _bar = 10;
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//ゲージに指定するSlider


    // Start is called before the first frame update
    void Start()
    {
        //スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

    }

    void Update()
    {
        _slider.value = _bar;//スライダーとbarの紐づけ
    }


    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "humster")//衝突した相手のタグがhumsterなら
        {
            _bar -= 1; //barを-1ずつ変える
        }

        if (_bar < 0)
        {
            // 最小を下回ったらもとの高さに戻す
            _bar = 10;
        }
    }
}
