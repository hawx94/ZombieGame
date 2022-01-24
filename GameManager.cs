using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool jogadorEstaVivo;
    public int inimigosDerrotados;
    public Text textoDePontuacaoAtual;
    public GameObject painelDeGameOver;
    public Text textoDePontuacaoFinal;
    public Text textoDeHighScore;

    // Start is called before the first frame update
    void Start()
    {
        jogadorEstaVivo = true;
        inimigosDerrotados = 0;
        textoDePontuacaoAtual.text = "Zombie Killed : " + inimigosDerrotados;
        
    }

    


    public void AumentarPontuacao()
    {
        inimigosDerrotados += 1;
        textoDePontuacaoAtual.text = "Zombie Killed : " + inimigosDerrotados; 
    }

    public void GameOver()
    {
        FindObjectOfType<Musicas>().TocarMusicaDeGameOver();
        Cursor.visible = true;
        painelDeGameOver.SetActive(true);
        jogadorEstaVivo = false;
        textoDePontuacaoFinal.text = "Zombies Killed : " + inimigosDerrotados;
        
       if(inimigosDerrotados > PlayerPrefs.GetInt("HighScore")) 
        {
            PlayerPrefs.SetInt("HighScore", inimigosDerrotados);  
        }

        textoDeHighScore.text = "HighScore : " + PlayerPrefs.GetInt("HighScore");  

    }

}

