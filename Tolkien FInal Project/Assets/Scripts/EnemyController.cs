using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    public float positiveXBorder;

    [SerializeField]
    public float negativeXBorder;

    private bool dirRight = true;

    // Start is called before the first frame update
    void Start()
    {
        //get the negative and positive x-axis boundary position from the SauronBorder objects
        positiveXBorder = GameObject.Find("SauronBorder1").transform.position.x;
        negativeXBorder = GameObject.Find("SauronBorder2").transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (gameObject.transform.position.x >= positiveXBorder)
        {
            dirRight = false;
        }
        else if (gameObject.transform.position.x <= negativeXBorder)
        {
            dirRight = true;
        }
    }
}
