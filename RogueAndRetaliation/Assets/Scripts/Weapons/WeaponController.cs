using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    /// <summary>
    /// base script for all weapons controllers
    /// </summary>

    [Header("Weapon stats")]
    public GameObject Prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    private float currentCooldown;
    public int pierce;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        currentCooldown = cooldownDuration;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <= 0f)
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = cooldownDuration;
    }
}
