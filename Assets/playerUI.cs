using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUI : MonoBehaviour
{
    [SerializeField] private CharacterController2D characterController;
    private int nbUIFood;
    Stack<GameObject> order = new Stack<GameObject>();
    Stack<GameObject> orderInv = new Stack<GameObject>();
    public GameObject container1;
    public GameObject container2;
    public GameObject container3;
    public GameObject container4;
    public GameObject prefab;

    private void Start()
    {
        
        orderInv.Push(container4);
        orderInv.Push(container3);
        orderInv.Push(container2);
        orderInv.Push(container1);
        print(orderInv.Count);

    }

    private void Update()
    {
        if (characterController.nbFood > nbUIFood)
        {
            CreateUIFood();
        }
        else if (characterController.nbFood < nbUIFood)
        {
            DeleteUIFood();
        }
    }

    private void CreateUIFood()
    {
        GameObject temp = orderInv.Pop();
        Instantiate(prefab, temp.transform);
        order.Push(temp);
        nbUIFood += 1;
    }

    private void DeleteUIFood()
    {
        GameObject temp = order.Pop();
        Destroy(temp.transform.GetChild(0).gameObject);
        orderInv.Push(temp);
        nbUIFood -= 1;
    }
}
