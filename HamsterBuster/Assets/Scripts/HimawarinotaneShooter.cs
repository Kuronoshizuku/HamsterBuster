using System.Collections;
using UnityEngine;
// みくみ

public class HimawarinotaneShooter : MonoBehaviour
{
    public GameObject seedPrefab;
    public float shotSpeed;
    public float shotTorque;
    public GameObject Shooter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Shot();
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
        seedRigidBody.AddTorque(new Vector3(0, shotTorque, 0));
    }
}