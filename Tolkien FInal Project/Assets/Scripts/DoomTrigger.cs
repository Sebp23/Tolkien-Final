using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoomTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject spacebarPrompt;

    private void Start()
    {
        spacebarPrompt.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            spacebarPrompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scene");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spacebarPrompt.SetActive(false);
    }
}
