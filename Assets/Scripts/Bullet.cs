using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));
    }
}