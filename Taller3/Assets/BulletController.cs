using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float maxDistance = 10f;
    private Vector3 initialPosition;
    
    private void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Vector3.Distance(initialPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
