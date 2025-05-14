using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TankView>() == null)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
