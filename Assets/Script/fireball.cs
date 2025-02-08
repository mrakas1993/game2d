using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed;
    private bool hitn;
    private float direction;
    private float lifeTime;

    private BoxCollider2D boxCollider;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hitn)
        {
            return;
        }
        float movementspeed = speed * Time.deltaTime * direction;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * direction, movementspeed);

        if (hit.collider != null)
        {
            OnTriggerEnter2D(hit.collider);
        }
        else
        {
            transform.Translate(movementspeed, 0, 0);
        }
        

        lifeTime += Time.deltaTime;
        if(lifeTime > 5) 
        {
            Deactivate();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitn = true;
        boxCollider.enabled = false;
        anim.SetTrigger("explode");

        if (collision.CompareTag("wall") || collision.CompareTag("ground"))
        {
            Debug.Log("wall or ground");
            Deactivate();
        }else if (collision.CompareTag("enemy"))
        {
            Debug.Log("enemy");
            Deactivate();
        }
    }
    public void SetDirection(float _direction)
    {
        lifeTime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hitn = false;

        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) != _direction)
        {
            localScaleX = -localScaleX;
        }
        transform.localScale = new Vector3(localScaleX,transform.localScale.y,transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

}
