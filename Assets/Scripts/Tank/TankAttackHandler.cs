using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankAttackHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody shellRb;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Slider aimSlider;


    [SerializeField] private float minLaunchForce = 15f;
    [SerializeField] private float maxLaunchForce = 30f;
    [SerializeField] private float maxChargeTime = 0.75f;

    private float currentLaunchForce;
    private float chargeSpeed;

    private bool firedShell;

    private void OnEnable()
    {
        currentLaunchForce = minLaunchForce;
        aimSlider.value = minLaunchForce;
    }

    private void Start()
    {
        chargeSpeed = (maxLaunchForce - minLaunchForce) / maxChargeTime;
    }
    private void Update()
    {
        if (currentLaunchForce >= maxLaunchForce && !firedShell)
        {
            currentLaunchForce = maxLaunchForce;
            Fire();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            firedShell = false;
            currentLaunchForce = minLaunchForce;
        }
        else if (Input.GetKey(KeyCode.Mouse0) && !firedShell)
        {
            //charge
            currentLaunchForce += chargeSpeed * Time.deltaTime;
            aimSlider.value = currentLaunchForce;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0) && !firedShell)
        {
            Fire();
        }

    }

    private void Fire()
    {
        firedShell = true;
        aimSlider.value = minLaunchForce;
        Rigidbody shellInstance = Instantiate(shellRb, shootPoint.position, shootPoint.rotation) as Rigidbody;

        shellInstance.velocity = shootPoint.transform.forward * currentLaunchForce;
    }
}
