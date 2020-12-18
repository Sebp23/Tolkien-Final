using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5f;

    public Rigidbody2D playerRB;
    private Vector2 input;
    private Vector3 movement;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        movement = new Vector3(input.x, input.y, 0);
        PlayerWalk();

        if (input.x != 0 || input.y != 0)
            anim.SetBool("moving", true);
        else
            anim.SetBool("moving", false);

        anim.SetFloat("x axis", input.x);
        anim.SetFloat("y axis", input.y);

        if (input.x > 0)
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
        }

        if (input.x < 0)
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
        if (input.y > 0)
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
        }
        if (input.y < 0)
        {
            anim.SetBool("down", true);
            anim.SetBool("up", false);
        }

        if (input.x == 0)
        {
            anim.SetBool("right", false);
            anim.SetBool("left", false);
        }

        if (input.y == 0)
        {
            anim.SetBool("up", false);
            anim.SetBool("up", false);
        }
    }

    private void PlayerWalk()
    {
        transform.position += movement * Time.deltaTime * movementSpeed;
    }
}
