using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// base scrift for all projectile behaviours (to be placed on the projectile prefab)
/// </summary>
public class ProjectileWeaponBehaviour : MonoBehaviour
{

    protected Vector3 direction;
    public float destroyTimer;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Destroy(gameObject, destroyTimer);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;
    }
}
