using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int stars = 0;

  [SerializeField] private TextMeshProUGUI starsText;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            stars++;
           
            starsText.text = ("Stars: " + stars);
        }
    }
}