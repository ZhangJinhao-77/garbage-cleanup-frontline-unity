using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public Collider2D coll;
    public Collider2D disColl;
    public Transform cellingCheck;
    public AudioSource jumpAudio, bottleAudio,hurtAudio;
   

    [Space]
    public float speed;
    public float jumpForce;
    [Space]
    public LayerMask ground;
    [SerializeField]
    private int Bottle;
    public Text BottleNum;
    
    private bool isHurt;//默认false



    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (!isHurt)
        {
            Movement();
            
        }
        
        SwitchAnim();
    }
    private void Update()
    {
        Jump();
        Crouch();
        BottleNum.text = Bottle.ToString();
    }

    //角色移动
    void Movement()
    {
        float horizontalMove=Input.GetAxis("Horizontal");
        float facedirection=Input.GetAxisRaw("Horizontal");

        //角色移动
        if (horizontalMove !=0)
        {
            rb.velocity = new Vector2 (horizontalMove *speed *Time .fixedDeltaTime ,rb.velocity .y);
            anim.SetFloat("running", Mathf.Abs(facedirection));

        }
        if(facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
       
        Crouch();
    }
    
    //切换动画效果
    void SwitchAnim()
    {
        //anim.SetBool("idle", false );
        if(rb.velocity.y < 0.1f && !coll.IsTouchingLayers(ground))
        {
            anim.SetBool("falling", true);
        }
        if (anim.GetBool ("jumping"))
        {
            if (rb.velocity .y < 0)
            {
                anim.SetBool("jumping", false);
                anim.SetBool("falling", true);
            }
        }else if (isHurt)
        {
            anim.SetBool("hurt", true);
            anim.SetFloat("running", 0);
            if (Mathf.Abs(rb.velocity.x) < 0.1f)
            {

                anim.SetBool("hurt", false);
                //anim.SetBool("idle", true);
                isHurt = false;
            }
        }
        else if (coll.IsTouchingLayers (ground ))
        {
            anim.SetBool("falling", false);
            //anim.SetBool("idle", true);
        }

    }

    //碰撞触发器
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //拾取物品
        if (collision.tag == "Collection")
        {
            bottleAudio.Play();//声音
                               // Destroy(collision.gameObject);
                               // Bottle += 1;
            collision.GetComponent<Animator>().Play("isGot");
           // BottleNum.text = Bottle.ToString ();
        }
        if (collision.tag == "DeadLine")
        {
            GetComponent<AudioSource>().enabled = false;
            Invoke("Restar", 1f);
        }

    }

    //消灭怪物
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();//调用其他种类函数的方法
            if (anim.GetBool("falling") )
            {
                enemy.JumpOn();
                
                rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
                anim.SetBool("jumping", true);
             //受伤
            }else if (transform .position.x < collision .gameObject.transform.position.x )
            {
                rb.velocity = new Vector2(-8, rb.velocity.y);
                hurtAudio.Play();
                isHurt = true;
            }
            else if (transform.position.x > collision.gameObject.transform.position.x)
            {
                rb.velocity = new Vector2(8, rb.velocity.y);
                hurtAudio.Play();
                isHurt = true;
            }
        }
    }

    //下蹲
    void Crouch()
    {
        if (!Physics2D.OverlapCircle(cellingCheck.position,0.2f,ground))
        {

            if (Input.GetButtonDown("Crouch"))
            {
                anim.SetBool("crouching", true);
                disColl.enabled = false;
            } else if (Input.GetButtonUp("Crouch"))
            {
                anim.SetBool("crouching", false);
                disColl.enabled = true;
            }
        }
    }
    //角色跳跃
    void Jump()
    {
        
        if (Input.GetButton("Jump") && coll.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.fixedDeltaTime);
            jumpAudio.Play();//声音
            anim.SetBool("jumping", true);

        }
    }

    //重置当前场景
    void Restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void BottleCount()
    {
        Bottle += 1;
    } 
}
