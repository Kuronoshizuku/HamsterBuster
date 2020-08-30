using UnityEngine;
using System.Collections;
//勝手に修正しました

public class TimeLimitBiru : MonoBehaviour
{
    //【追加】SE
    public AudioSource audioSource;
    public AudioClip sound01;

    public float life_time;
    float time = 0f;

    // Use this for initialization
    void Start()
    {
        time = 0;
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //print(time);
        if (time > life_time)
        {
            enabled = false;
            //【追加】SEを再生
            audioSource.PlayOneShot(sound01);
            Destroy(gameObject);
            //StartCoroutine(timer());
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

}