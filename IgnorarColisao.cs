using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorarColisao : MonoBehaviour
{


    private BoxCollider2D zombieColider, parede1,parede2,parede3,parede4;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        zombieColider = GetComponent<BoxCollider2D>();
        parede1 = GameObject.Find("Parede").GetComponent<BoxCollider2D>();
        parede2 = GameObject.Find("Parede (1)").GetComponent<BoxCollider2D>();
        parede3 = GameObject.Find("Parede (2)").GetComponent<BoxCollider2D>();
        parede4 = GameObject.Find("Parede (3)").GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(parede1, zombieColider, true); 
        Physics2D.IgnoreCollision(parede2, zombieColider, true); 
        Physics2D.IgnoreCollision(parede3, zombieColider, true); 
        Physics2D.IgnoreCollision(parede4, zombieColider, true); 
    }

}   
