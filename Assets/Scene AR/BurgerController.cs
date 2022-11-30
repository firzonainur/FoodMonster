using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BurgerController : MonoBehaviour
{
    public float playerSpeed;
    public float jumpSpeed;

    private bool isJumping;
    private float move;
    private Rigidbody rb;
    private Animator anim;
    Vector3 scale;
    //public GameObject btnAR;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }
    void Update()
    {
        move = CrossPlatformInputManager.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        //untuk menghadap kanan dan kiri
        if (move < 0)
        {
            //transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move > 0)
        {
            //transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (CrossPlatformInputManager.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }

        if (PlayerPrefs.GetInt("akumulasiNyawa") == 3)
        {
            scale = new Vector3(0.3f, 0.3f, 0.3f);
            gameObject.transform.localScale = scale;
        }

        if (PlayerPrefs.GetInt("akumulasiNyawa") == 2)
        {
            scale = new Vector3(0.4f, 0.4f, 0.4f);
            gameObject.transform.localScale = scale;
        }

        if (PlayerPrefs.GetInt("akumulasiNyawa") == 1)
        {
            scale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.localScale = scale;
        }

        if (PlayerPrefs.GetInt("akumulasiNyawa") == 0)
        {
            scale = new Vector3(0.8f, 0.8f, 0.8f);
            gameObject.transform.localScale = scale;
            //btnAR.SetActive(true);
        }

        RunAnimations();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void RunAnimations()
    {
        anim.SetFloat("isWalk", Mathf.Abs(move));
        anim.SetBool("isJump", isJumping);
    }





}
