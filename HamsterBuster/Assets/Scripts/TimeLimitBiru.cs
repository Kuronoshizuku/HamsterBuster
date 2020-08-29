using UnityEngine;
using System.Collections;

public class TimeLimitBiru : MonoBehaviour
{
    //【追加】SE
    public AudioClip sound01;

    public float life_time = 1.5f;
    float time = 0f;

    // Use this for initialization
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        print(time);
        if (time > life_time)
        {
            //【追加】SEを再生
            AudioSource.PlayClipAtPoint(sound01, transform.position);

            Destroy(gameObject);
        }
    }
}