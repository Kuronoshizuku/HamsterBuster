using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changehumster : MonoBehaviour
{
    public GameObject[] angly_HumsterPrefab;
    public GameObject[] Happy_HumsterPrefab;
    
    void OnOnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "seed")
        {
            GetComponent<Prefab>().GameObject.angly_HumsterPrefab= GameObject.Happy_HumsterPrefab;
        }
    }
}
