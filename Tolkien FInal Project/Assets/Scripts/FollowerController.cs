using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : MonoBehaviour
{
    [SerializeField]
    private Transform objectToFollow;

    [SerializeField]
    private Vector3 offset;

    private PlayerController playerControllerScript;
    private Animator anim;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerControllerScript.input.x != 0 || playerControllerScript.input.y != 0)
            anim.SetBool("moving", true);
        else
            anim.SetBool("moving", false);

        anim.SetFloat("x axis", playerControllerScript.input.x);
        anim.SetFloat("y axis", playerControllerScript.input.y);

        if (playerControllerScript.input.x > 0)
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
        }

        if (playerControllerScript.input.x < 0)
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
        if (playerControllerScript.input.y > 0)
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
        }
        if (playerControllerScript.input.y < 0)
        {
            anim.SetBool("down", true);
            anim.SetBool("up", false);
        }

        if (playerControllerScript.input.x == 0)
        {
            anim.SetBool("right", false);
            anim.SetBool("left", false);
        }

        if (playerControllerScript.input.y == 0)
        {
            anim.SetBool("up", false);
            anim.SetBool("up", false);
        }

        transform.position = objectToFollow.position + offset;
    }
}
