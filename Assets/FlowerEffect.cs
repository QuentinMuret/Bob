using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerEffect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    Color color1 = Color.cyan;
    Color color2= Color.red;

    private void Start()
    {
        spriteRenderer.color = color1;
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteRenderer.color = color2;
            print("ho");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteRenderer.color = color1;
            print("hey");
        }
    }
}
