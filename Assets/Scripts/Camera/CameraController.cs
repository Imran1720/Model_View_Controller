using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform targetToFollow;

    [SerializeField] private float followSpeed;

    private Vector3 offset;
    private Vector3 currentVelocity = Vector3.zero;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }
    private void LateUpdate()
    {
        if ((targetToFollow != null))
        {
            Vector3 targetPosition = targetToFollow.position - offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, followSpeed);
        }
    }

    public void SetTarget(Transform _target)
    {

        targetToFollow = _target;
        offset = targetToFollow.position - transform.position;
    }

    public IEnumerator ShakeCamera(float _duration, float magnitude)
    {
        Vector3 originalPosition = mainCamera.transform.position;

        float elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            float xShake = Random.Range(-1f, 1f) * magnitude;
            float yShake = Random.Range(-1f, 1f) * magnitude;

            mainCamera.transform.localPosition = new Vector3(xShake, yShake, 0);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        mainCamera.transform.localPosition = Vector3.zero;

    }

}
