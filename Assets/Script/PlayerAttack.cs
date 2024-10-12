using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackCooldown;
    public Transform firePoint;
    public GameObject[] fireBalls;

    private Animator anim;
    private PlayerMovment playerMovment;
    private float cooldownTimer = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovment = GetComponent<PlayerMovment>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
