using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    [SerializeField] private Text FluidsText;
    private int fluidss = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fluids"))
        {
            Destroy(collision.gameObject);
            fluidss++;
            FluidsText.text = "Fluids: " + fluidss;


        }
    }
}
