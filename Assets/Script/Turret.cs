using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 1f;
    public float x = 10f;
    public float y = 0f;
    public GameObject shootpos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, shootingInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Shoot()
    {
        GameObject bullet  = Instantiate(bulletPrefab,shootpos.transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(x, y);
    }
}
