using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sauron"))
        {
            Debug.Log("Dead!");
            SceneManager.LoadScene("Death Screen");
        }
    }
}
