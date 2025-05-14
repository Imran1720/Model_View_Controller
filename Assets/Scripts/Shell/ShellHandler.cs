using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    private CameraController cameraController;
    private CapsuleCollider currentCollider;
    private void Start()
    {
        cameraController = Camera.main.GetComponentInParent<CameraController>();
        currentCollider = GetComponent<CapsuleCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<TankView>())
        {
            PerformTriggerAction();
            Destroy(gameObject, 2f);
        }
    }

    private void PerformTriggerAction()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        DisableInteraction();
        StartCoroutine(cameraController.ShakeCamera(.14f, .4f));
    }

    private void DisableInteraction()
    {
        currentCollider.enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponentInChildren<ParticleSystem>().gameObject.SetActive(false);
    }
}
