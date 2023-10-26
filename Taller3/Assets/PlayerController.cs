using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
    public float moveSpeed = 15.0f;
    private Rigidbody rb;
    public GameObject bulletPrefab;
    public Transform cannonTransform;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        rb.velocity = movement * moveSpeed;

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }

        void FireBullet()
        {
            if (bulletPrefab != null && cannonTransform != null)
            {
                GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);


            }
        }
    }
}
