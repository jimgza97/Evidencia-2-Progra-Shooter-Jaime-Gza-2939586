using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;
    public float fireSpeed = .1f;

    public ParticleSystem muzzleFlash;
    public Camera fpsCam;
    public GameObject impactEffect;

    private float NextFire;

    private void Update() {
        if (Input.GetButton("Fire1") && Time.time > NextFire)       //so it auto shoots when holding Fire1
        {
            NextFire = Time.time + fireSpeed;
            Shoot();
        }
    }

    void Shoot() {

        muzzleFlash.Play();
        AudioSource shootSound = GetComponent<AudioSource>();
        shootSound.Play();

        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit,range)) {
            Debug.Log(hit.transform.name);
        }
        Target target = hit.transform.GetComponent<Target>();

        if(target != null) {
            target.TakeDamage(damage);
        }

        GameObject impactGo = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impactGo, 2f);
    }
}
