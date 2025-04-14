using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagesPlayer : MonoBehaviour {

    public int damage = 4;

    void OnCollisionEnter(Collision col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(damage);
            AudioSource shootSound = GetComponent<AudioSource>();
            shootSound.Play();
        }
    }
}
