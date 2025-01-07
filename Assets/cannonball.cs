using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
{
    public float life = 5f;
    private Vector3 initPos;

    private void Awake()
    {
        initPos = transform.position;
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        float distanceTravelled = Vector3.Distance(initPos, transform.position);

        Debug.Log($"Distance travelled: {distanceTravelled}");

        Destroy(gameObject);
    }
}
