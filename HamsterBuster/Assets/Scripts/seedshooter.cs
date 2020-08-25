using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedshooter : MonoBehaviour
{
    public GameObject seedPrefab;
    public float shotSpeed;
    public float shotTorque;

    void Update()
    {
        if (Input.GetButtonDown("Fire2")) Shot();
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