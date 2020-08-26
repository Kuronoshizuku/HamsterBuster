using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
// みくみ

public class seedDestroyer : MonoBehaviour
{
    public GameObject scoreGUI;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("接触 + other.gameObject.name");

        if (other.gameObject.tag == "humster")
        {
            Destroy(other.gameObject,0.2f);
            Destroy(gameObject,0.2f);

            UInumScript.score += 150;


        }
        if(other.gameObject.tag == "Ground")
        {
            Destroy(gameObject,0.2f);
        }
    }
}