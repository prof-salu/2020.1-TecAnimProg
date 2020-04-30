using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigos : MonoBehaviour
{
    private GameObject jogador;
    public GameObject inimigo;
    public float intervaloCriacao = 3f;
    private float timerCriacao = 0;
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

        timerCriacao -= Time.deltaTime;

        if(timerCriacao <= 0)
        {
            timerCriacao = intervaloCriacao;
            Instantiate(inimigo, transform.position, transform.rotation);
        }
    }
}
