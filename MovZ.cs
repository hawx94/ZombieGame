using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovZ : MonoBehaviour
{
    public float velMin;
    public float velMax;
    public float velAtual;

    public int danoDoZumbie;

    private Rigidbody2D oRigid;
    private Transform oJogador;

    // Start is called before the first frame update
    void Start()
    {
        velAtual = Random.Range(velMin, velMax);
        oRigid = GetComponent<Rigidbody2D>();
        oJogador = FindObjectOfType<MovJogador>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoZ();
    }

    // movimentaçao do zombie
    void MovimentoZ()
    {
            if(FindObjectOfType<GameManager >().jogadorEstaVivo == true ) 
            {
            
                transform.position = Vector2.MoveTowards(transform.position, oJogador.position, velAtual * Time.deltaTime);
                Vector3 direcaoDoInimigo = oJogador.position - transform.position;
                float anguloOlhar = Mathf.Atan2(direcaoDoInimigo.y, direcaoDoInimigo.x) * Mathf.Rad2Deg;
                oRigid.rotation = anguloOlhar;
            }
    }


    // ataque do zombie
     void OnCollisionEnter2D(Collision2D collisioni)
    {
        if (collisioni.gameObject.CompareTag("Player"))
        {
            collisioni.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoDoZumbie );
            
        }  
    }
}
