using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJogador : MonoBehaviour
{
    // VARIAVEIS
    public float velocidadeDoJogador;
    private Vector2 movimentoDoJogador;
    public Rigidbody2D oRig;
    public Camera cameraDOJogo;
    private Vector2 posicaorato;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        PositionRato();


    }

   void FixedUpdate()
    {
        oRig.MovePosition(oRig.position + movimentoDoJogador.normalized * velocidadeDoJogador* Time.deltaTime);
        Vector2 direcaoDoOlhar = posicaorato - oRig.position;
        float anguloDoJogador = Mathf.Atan2(direcaoDoOlhar.y, direcaoDoOlhar.x) * Mathf.Rad2Deg;
        oRig.rotation = anguloDoJogador;
    }
    // Movimentar o jogador
    void Move()
    {
        movimentoDoJogador.x = Input.GetAxisRaw("Horizontal");
        movimentoDoJogador.y = Input.GetAxisRaw("Vertical");
    }

    // Posicao do Mouse
    void PositionRato()
    {
        posicaorato = cameraDOJogo.ScreenToWorldPoint(Input.mousePosition);
    }




}
