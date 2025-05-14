using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHandeler : MonoBehaviour, ISelfDestruct
{
    private void Start()
    {
        Invoke("SelfDestruct", 4);
    }
    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
