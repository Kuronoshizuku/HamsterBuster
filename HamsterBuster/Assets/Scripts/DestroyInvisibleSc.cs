using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvisibleSc : MonoBehaviour
{
    //ただしこの処理には一点問題があります。
    //ゲーム画面上のすべてのカメラから映らなくなったとしても、
    //Unityエディタ上のScene画面やPreview画面にオブジェクトが表示されていると、この関数は呼ばれない


    //カメラに写ってないときに呼ばれる関数
    //カメラに写ってないオブジェクトを削除

    void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);

    }

}
