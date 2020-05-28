using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPowerUp : MonoBehaviour
{
    public float velDeslocamento = 1;
    private GameObject jogador;

    void Update()
    {
        if(jogador == null)
        {
            jogador = GameObject.FindWithTag("Player");
        }

        if(jogador == null)
        {
            return;
        }

        Vector3 posicao = transform.position;
        Vector3 velocidade = new Vector3(0, velDeslocamento * Time.deltaTime, 0);
        posicao -= velocidade;

        transform.position = posicao;

        if(posicao.y + 2 < -Camera.main.orthographicSize)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(gameObject.name == "PowerupVelocidade")
            {
                jogador.GetComponent<ControlaJogador>().velocidadeMax += 1;
            }

            if (gameObject.name == "PowerupTiro")
            {
                jogador.GetComponent<ControlaDisparo>().atrasoNoDisparo -= 0.5f;
            }

            if (gameObject.name == "PowerupEscudo")
            {
                jogador.GetComponent<AtivaEscudo>().timerRecargaEscudo -= 1.5f;
            }

            Destroy(transform.parent.gameObject);
        }
    }
}