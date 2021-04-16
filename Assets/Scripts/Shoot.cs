using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public ParticleSystem collisionExplosionPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            muzzleFlash.Play();

            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
            {
                ParticleSystem collisionExplosion = Instantiate(collisionExplosionPrefab, hitInfo.point, Quaternion.identity);
                collisionExplosion.transform.LookAt(hitInfo.normal);
            }
        }
    }
}
