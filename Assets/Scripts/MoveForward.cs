using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speedMoviment;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
    }

    void OnMove()
    {
        transform.Translate(Vector3.forward * (speedMoviment * Time.deltaTime));
    }
}
