using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedMoviment;

    private float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        OnMove();
    }

    void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");   
    }
    void OnMove()
    {
        if (horizontalInput > 0)
        {
            transform.Translate(-Vector3.right * (speedMoviment * Time.deltaTime));
        }

        if (horizontalInput < 0)
        {
            transform.Translate(-Vector3.left * (speedMoviment * Time.deltaTime));
        }
        
    }
}
