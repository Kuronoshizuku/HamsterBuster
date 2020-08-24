using System.Collections;
using UnityEngine;
// みくみ

public class seedDestroyer : MonoBehaviour
{
    public GameObject Seed;
    GameObject humster;

    private void Start()
    {
        Seed = GameObject.Find("seed");
        humster = GameObject.Find("humster");
    }


    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("接触 + collision.gameObject.name");

        if (collision.gameObject.tag == "humster")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}