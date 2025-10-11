using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;

    public float BulletSpeed
    {
        get { return speed; }
        set {speed = value; }
    }
    
    void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
        
    }
    
    
}