using System.Collections;
using UnityEngine;
// みくみ

public class HimawarinotaneShooter : MonoBehaviour
{
    public GameObject seedPrefab;
    public float shotSpeed;
    public GameObject Shooter;
    //数を制限するぞ～
    public int shotCount; //inspectorで数を入れよう

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shotCount < 1)
                return;
            Shot();
            //shotCountの数値を１ずつ減らす。
            shotCount -= 1;
        }
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