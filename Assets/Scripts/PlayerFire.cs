using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    [SerializeField] private AudioSource weaponAudioSource;
    [SerializeField] private AudioClip shotAudioClip;
    [SerializeField] private AudioClip reloadAudioClip; // Update is called once per frame
    void Update()
    {
        OnFire();
        OnReload();
    }

    void OnFire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateNewBullet();
        }
    }

    void CreateNewBullet()
    {
        Instantiate(bullet, firePoint.position, bullet.transform.rotation);
        weaponAudioSource.PlayOneShot(shotAudioClip);
    }

    void OnReload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            weaponAudioSource.PlayOneShot(reloadAudioClip);
        }
    }
    
}
