using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconeDeVida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player")  )
        {
            outro.gameObject.GetComponent<VidaDoJogador>().GanharVida();
            Destroy(this.gameObject);
        }
    }



}
