using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyball : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -8.88f)
        {
            Destroy(gameObject);
        }
    }
}
