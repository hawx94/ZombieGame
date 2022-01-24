using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    public Transform localDoAtaque;
    public GameObject projetil;
    public AudioSource somDeAtaque;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparo();
    }


    void Disparo()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projetil, localDoAtaque.position, localDoAtaque.rotation);
            somDeAtaque.Play();
            
        }

       

    }






}
