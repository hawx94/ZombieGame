using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDosInimigos : MonoBehaviour
{
    public GameObject zumbie;

    public Transform[] pontoDeSpawn;

    public float tempoEntreOsSpawns;
    public float tempoAtual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().jogadorEstaVivo == true) 
        {
            tempoAtual -= Time.deltaTime;
            if(tempoAtual <= 0) 
            {
                SpawnarInimigos();
            }
        }
    }

    public void SpawnarInimigos()
    {
        int pontoAleatorio = Random.Range(0, pontoDeSpawn.Length);
        Instantiate(zumbie, pontoDeSpawn[pontoAleatorio].position, pontoDeSpawn[pontoAleatorio].rotation);
        tempoAtual = tempoEntreOsSpawns; 
    }
}
