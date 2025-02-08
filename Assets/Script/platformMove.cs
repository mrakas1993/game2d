using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public float speed;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position  = Vector3.MoveTowards(transform.position,target.position,speed*Time.deltaTime);

        
    }
}
