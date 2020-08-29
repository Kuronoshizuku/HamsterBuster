using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// みくみ

public class HimawarinotaneShooter : MonoBehaviour
{
    public GameObject seedPrefab;
    public float shotSpeed;
    public GameObject Shooter;
    //数を制限するぞ～
    public static int shotCount = 50; //static にしてみた
    public Text text;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (shotCount < 1)
            //    return;
            if (shotCount < 1)
            {
                text.GetComponent<Text>().color = new Color(100, 100, 100);
                StartCoroutine(timer());
            }
            else
            {
                Shot();
                //shotCountの数値を１ずつ減らす。
                shotCount -= 1;
            }
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("HamuOverGame");
    }

    public void Shot()
    {
        GameObject seed = (GameObject)Instantiate(
            seedPrefab,
            transform.position,
            Quaternion.identity
            );


        Rigidbody seedRigidBody = seed.GetComponent<Rigidbody>();
        seedRigidBody.AddForce(transform.forward * shotSpeed);
    }
}