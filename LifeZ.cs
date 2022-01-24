using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeZ : MonoBehaviour
{
    public int vidaMaxz;
    public int vidaAtualz;
    public GameObject objetoParaDropar;
    

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualz = vidaMaxz;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Dano(int danoR)
    {
        vidaAtualz -= danoR;
         

        if (vidaAtualz <=0)
        {
            FindObjectOfType<GameManager>().AumentarPontuacao();
            int numeroAleatorio = Random.Range(0, 10); // sortear numero aleatorio
            if(numeroAleatorio < 1)
            {
                Instantiate(objetoParaDropar, transform.position, transform.rotation); 
            }
            Destroy(this.gameObject);

        }
    }



}
