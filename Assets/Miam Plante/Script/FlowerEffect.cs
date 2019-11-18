using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerEffect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    Color color1 = Color.cyan;
    Color color2= Color.red;

    public Sprite normal;
    public Sprite peur;

    private void Start()
    {
        
        spriteRenderer.sprite = normal;
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           
            spriteRenderer.sprite = peur;
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteRenderer.sprite = normal;
            
        }
    }
}
