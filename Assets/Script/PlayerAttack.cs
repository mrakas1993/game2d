using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //public float attackCooldown;
    //public Transform firePoint;
    //public GameObject[] fireBalls;

    //private Animator anim;
    //private PlayerMovment playerMovment;
    //private float cooldownTimer = Mathf.Infinity;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    anim = GetComponent<Animator>();
    //    playerMovment = GetComponent<PlayerMovment>();

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0) && cooldownTimer > attackCooldown && playerMovment.canAttack())
    //    {
    //        Attack();
    //    }
    //    cooldownTimer += Time.deltaTime;
    //}
    //private void Attack()
    //{


    //    int fireballIndex = FindFireBall();
    //    if (fireballIndex == -1)
    //    {
    //        return;
    //    }

    //    anim.SetTrigger("attack");
    //    cooldownTimer = 0;

    //    fireBalls[fireballIndex].transform.position = firePoint.position;
    //    fireBalls[fireballIndex].GetComponent<fireball>().SetDirection(Mathf.Sign(transform.localScale.x));
    //}
    //private int FindFireBall()
    //{
    //    for (int i = 0; i < fireBalls.Length; i++)
    //    {
    //        if (!fireBalls[i].activeInHierarchy)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}
    //public Transform shotPos;
    //public GameObject Bullet;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(Bullet, shotPos.transform.position, transform.rotation);

    //    }

    //}
    public float fireRate = 0.5f;
    public GameObject projectilePrefab;
    public Transform firePoint;

    private float nextFireTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            nextFireTime = Time.time + fireRate;
        }
    }
}
