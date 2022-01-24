using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{

    public int danoArmadilha;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zombie"))
        {
            collision.gameObject.GetComponent<LifeZ>().Dano(danoArmadilha);

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<VidaDoJogador>().MachucarJogador( danoArmadilha);
        }


    }

}
