using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "humster")
        {
            Destroy(other.gameObject);
        }

    }
}
