using UnityEngine;

public class DestroyAfterLimit : MonoBehaviour
{
    [SerializeField] private float maxLimitToDestroy;

    // Update is called once per frame
    void Update()
    {
        DestroyNegativeZPosition();
    }

    void DestroyNegativeZPosition()
    {
        if (transform.position.z <= maxLimitToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
