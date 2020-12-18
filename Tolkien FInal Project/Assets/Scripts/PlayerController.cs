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
    }

    private void PlayerWalk()
    {
        transform.position += movement * Time.deltaTime * movementSpeed;
    }
}
