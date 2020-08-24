using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEshiikuin : MonoBehaviour
{
    public AudioClip shootsound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //getConponent
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Spacekey");
            audioSource.PlayOneShot(shootsound);
        }
    }
}
