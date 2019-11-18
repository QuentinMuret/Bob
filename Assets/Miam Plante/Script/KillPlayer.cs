using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    
    public float terrainLimiteZ = -5f;
    public event System.Action OnPlayerDeath;

    
    private void Update()
    {
        if (transform.position.y < terrainLimiteZ)
        {
            OnPlayerDeath?.Invoke();

        }
        if (transform.position.y < terrainLimiteZ-10)
        {
            Destroy(gameObject);
        }
    }
    
}
