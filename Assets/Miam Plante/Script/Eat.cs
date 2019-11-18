using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    GameObject objectToEat;
    public CharacterController2D characterController;

   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Eatable"))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                objectToEat = collision.gameObject;
                Invoke("EatObject", 0.5f);
                if (characterController.nbFood<4)
                {
                    characterController.nbFood += 1;
                }
                

               
            }

        }
        
    }

    private void EatObject()
    {
        Destroy(objectToEat);
    }
}
