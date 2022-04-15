using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShot : MonoBehaviour
{
    public float shootspeed, shoottimer;

    private bool Ishooting = false;
    public Transform shootpos;
    public GameObject ball;



    void Start()
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mouseWorldPosition;
    }


    void Update()
    {
        if (Input.GetMouseButton(0) && !Ishooting)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        Ishooting = true;
        GameObject newBall = Instantiate(ball, shootpos.position, Quaternion.identity);
        Rigidbody2D newballrgb = newBall.GetComponent<Rigidbody2D>();
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newballrgb.velocity = new Vector2(mouseWorldPosition.x, shootspeed * Time.fixedDeltaTime);
        yield return new WaitForSeconds(shoottimer);
        Ishooting = false;
    }
}
