using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public int health;
    public int ininthealth;
    public Image HealthBar;

    void Start()
    {

        ininthealth = health;

    }


    void Update()
    {
        HealthBar.fillAmount = (float)health / ininthealth;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
        //else if (collision.gameObject.CompareTag("Finish"))
        //{
        //    Debug.Log("calýstý");
        //    SceneManager.LoadScene("Game");
        //}
    }

    //public void SkeletonPositionDown()
    //{

    //    for (int i = 1; i < 5; i++)
    //    {
    //        transform.position = new Vector2(transform.position.x, transform.position.y - i);
    //    }
    //}


}
