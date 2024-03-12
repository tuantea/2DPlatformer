using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource finishSound;

    private bool levelCompleted =false;
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Player"&& !levelCompleted) 
        { 
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
         //CompleteLevel(); 
        }
    }
    // Update is called once per frame
    void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
