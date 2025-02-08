using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healadd : MonoBehaviour
{
    public float add;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<health>().AddHealth(add);
            Destroy(gameObject);
        }
    }
}
