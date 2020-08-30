using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
// みくみ

public class seedDestroyer : MonoBehaviour
{
    public GameObject scoreGUI;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("接触" + other.gameObject.name);

        if (other.gameObject.tag == "humster")
        {
            Destroy(other.gameObject,0.2f);
            Destroy(gameObject,0.2f);

            UInumScript.score += 1;
        }

        if(other.gameObject.tag == "Ground")
        {
            Destroy(gameObject,0.2f);
        }
    }


    /*void changeAnimator()
    {
        Happyhumster = (GameObject)Resources.Load("Prefabs/Happy_Humster");
        //↑死亡時のアニメーションプレハブを読み込み
        Instantiate(
            Happyhumster,
            new Vector3(rb.transform.position.x, rb.transform.position.y),
            Quaternion.identity
            );

    }*/
}