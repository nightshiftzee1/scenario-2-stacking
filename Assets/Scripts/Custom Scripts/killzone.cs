using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour
{
    //Remove point and destroy cricles on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.instance.RemovePoint();
        Destroy(collision.gameObject);
    }
}
