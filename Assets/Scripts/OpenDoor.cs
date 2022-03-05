using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OpenDoor : MonoBehaviour
{
    public Text text;
    public string levelName;
    private bool inDoor = false;

    private float doorTime = 2.5f;
    private float startTime = 2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
        inDoor = false;

        doorTime = startTime;
    }

    private void Update()
    {
        if (inDoor)
        {
            doorTime -= Time.deltaTime;
        }

        if(doorTime <= 0)
        {
            SceneManager.LoadScene(levelName);
        }

        if (inDoor && Input.GetKey("e")){
            SceneManager.LoadScene(levelName);
        }
    }

}
