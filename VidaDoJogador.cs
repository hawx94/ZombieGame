using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{

    public int vidaMaxP;
    public int vidaAtualP;
    public Slider barraDeVida;
    public AudioSource somDeDano;
    public AudioSource somDeViada;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        vidaAtualP = vidaMaxP;
        barraDeVida.maxValue = vidaMaxP;
        barraDeVida.value = vidaAtualP; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GanharVida()
    {
        if(vidaAtualP < vidaMaxP)
        {
            vidaAtualP += 1;
            barraDeVida.value = vidaAtualP; 
        }
        else
        {
            vidaAtualP = vidaMaxP;
            barraDeVida.value = vidaAtualP;
        }
        somDeViada.Play(); 
    }


    public void MachucarJogador(int danozumbi)
    {
        vidaAtualP -= danozumbi;
        somDeDano.Play(); 
        barraDeVida.value = vidaAtualP; 

        if(vidaAtualP <= 0)
        {
            FindObjectOfType<GameManager>().GameOver (); 
            Destroy(this.gameObject);

        }
    }





}
