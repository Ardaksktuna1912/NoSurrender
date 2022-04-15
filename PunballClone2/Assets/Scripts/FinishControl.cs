using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishControl : MonoBehaviour
{

    public Transform skeletonpos;

    void Start()
    {
        //Skeposdown();

    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            Skeposdown();
        }


    }

    void Skeposdown()
    {
        skeletonpos.position = new Vector2(skeletonpos.position.x, skeletonpos.position.y - 1);
    }
}
