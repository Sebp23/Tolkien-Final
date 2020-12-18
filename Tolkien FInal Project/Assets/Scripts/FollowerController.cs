using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : MonoBehaviour
{
    [SerializeField]
    private Transform objectToFollow;

    [SerializeField]
    private Vector3 offset;
    
    void Update()
    {
        transform.position = objectToFollow.position + offset;
    }
}
