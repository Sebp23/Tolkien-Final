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

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        movement = new Vector3(input.x, input.y, 0);
        PlayerWalk();
    }

    private void PlayerWalk()
    {
        transform.position += movement * Time.deltaTime * movementSpeed;
    }
}
