using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMcontroller : MonoBehaviour
{
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        //audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
