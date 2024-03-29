using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // Start is called before the first frame update
    private int cherries = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource audioCherries;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            audioCherries.Play();
            cherries++;
            Debug.Log("Cherries:" + cherries);
            cherriesText.text = "Cherries: "+ cherries;
        }
    }
}
