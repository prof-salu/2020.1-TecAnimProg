using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaEscudo : MonoBehaviour
{
    public float timerDesligaEscudo = 5f;

    // Update is called once per frame
    void Update()
    {
        timerDesligaEscudo -= Time.deltaTime;

        if(timerDesligaEscudo <= 0)
        {
            DestruirEscudo();
        }
    }

    public void DestruirEscudo()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("LaserInimigo") || collision.CompareTag("Asteroide") || collision.CompareTag("NaveInimiga"))
        {
            Destroy(collision.gameObject);
        }
    }
}
