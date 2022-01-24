using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public float velProjetil;
    public int danoTiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velProjetil * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zombie"))
        {
            collision.gameObject.GetComponent<LifeZ>().Dano(danoTiro );
            Destroy(this.gameObject); 
        }
        if (collision.gameObject.CompareTag("parede"))
        {
            
            Destroy(this.gameObject);
        }

    }
}
