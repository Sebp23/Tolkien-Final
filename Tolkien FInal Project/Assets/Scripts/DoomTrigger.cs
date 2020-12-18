using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoomTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject spacebarPrompt;

    [SerializeField]
    private GameObject doomText;

    private void Start()
    {
        spacebarPrompt.SetActive(false);
        doomText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doomText.SetActive(true);
            spacebarPrompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("WinScreen");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        doomText.SetActive(false);
        spacebarPrompt.SetActive(false);
    }
}
