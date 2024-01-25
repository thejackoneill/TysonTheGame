using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class GunFireScript : MonoBehaviour
{
    private int ammoCurrent = 10;
    private int ammoMax = 10;

    [SerializeField]
    Transform muzzle;

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    float shotSound;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    AudioClip[] shotSounds;

    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        AudioSource audioSource;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject bullet = Instantiate(bulletPrefab);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            //Random Audio for gunfire
            int RandomIndex = shotSounds.Length;
        }

        
    }

    private void Reload()
    {
        if (ammoCurrent > ammoMax)
        { 
        
        }
    }
}
