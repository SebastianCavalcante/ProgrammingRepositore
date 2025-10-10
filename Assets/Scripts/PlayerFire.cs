using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        OnFire();
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
    }
    
}
