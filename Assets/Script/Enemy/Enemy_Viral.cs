using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Viral : Enemy
{
    private Rigidbody2D rb;
    //private Animator Anim;
    public Transform leftpoint, rightpoint;
    public float Speed;
    public float leftx, rightx;
    private bool Faceleft = true;

    protected override void Start()//调用父类函数方法
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();
        // Anim = GetComponent<Animator>();

        //删去父子关系transform.DetachChildren();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
    }


    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Faceleft)
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            if (transform.position.x < leftx)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                Faceleft = false;
            }
        }
        else
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            if (transform.position.x > rightx)
            {
                transform.localScale = new Vector3(1, 1, 1);
                Faceleft = true;
            }
        }
    }
}
