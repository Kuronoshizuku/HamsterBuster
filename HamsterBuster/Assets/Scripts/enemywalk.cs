using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywalk : MonoBehaviour
{
    private Vector3 enemypos;

    void Start()
    {
        enemypos = transform.position;
    }

    void Update()
    {
        // transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + enemypos.y, enemypos.z);
        this.transform.position = new Vector3(enemypos.x, enemypos.y, Mathf.Sin(Time.time) * 4.0f + enemypos.z);
    }
}