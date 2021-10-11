using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePowerUp : MonoBehaviour
{

    public GameObject pickupEffect;
    public float multiplier = 1.4f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        TankHealth stats = player.GetComponent<TankHealth>();
        stats.m_CurrentHealth *= multiplier;

        Destroy(gameObject);
    }

    public void Update()
    {
        
    }
}
