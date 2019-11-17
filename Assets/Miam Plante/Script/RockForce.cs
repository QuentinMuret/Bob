using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockForce : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        InvokeRepeating("ApplyForce", 0f, 0.5f);
    }

    // Update is called once per frame
    void ApplyForce()
    {
        m_Rigidbody2D.AddForce(new Vector2(0f, force));
    }
}
