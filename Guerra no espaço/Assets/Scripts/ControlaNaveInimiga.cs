using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaNaveInimiga : MonoBehaviour
{
    public float velRotacao = 90f;
    public float velDeslocamento = 3f;
    public float atrasoDisparo = 1f;
    private float timerDisparo = 0;
    public float distanciaDoTiro = 4;

    private GameObject jogador;
    public GameObject laser;
    public AudioClip somExplosao;

    private void Update()
    {
        if(jogador == null)
        {
            jogador = GameObject.FindWithTag("Player");
        }

        if(jogador == null)
        {
            return;
        }

        RotacionarNave();

        PerseguirJogador();

        Atirar();
    }

    private void RotacionarNave()
    {
        Vector3 direcao = jogador.transform.position - this.transform.position;

        //Quando normalizado, um vetor mantem a mesma direção, mas seu comprimento é 1.0
        direcao.Normalize();

        float eixoZ = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg - 90;

        Quaternion novaRotacao = Quaternion.Euler(0, 0, eixoZ);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, novaRotacao, velRotacao * Time.deltaTime);
    }

    private void PerseguirJogador()
    {
        Vector3 posicao = transform.position;

        Vector3 velocidade = new Vector3(0, velDeslocamento * Time.deltaTime, 0);

        posicao += transform.rotation * velocidade;

        transform.position = posicao;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LaserJogador"))
        {
            ControlaAudio.Instancia.PlayOneShot(somExplosao);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            ControlaJogo.placar += 150;
        }
    }

    private void Atirar()
    {
        timerDisparo -= Time.deltaTime;

        if(timerDisparo < 0 && jogador != null && Vector3.Distance(this.transform.position, jogador.transform.position) < distanciaDoTiro)
        {
            timerDisparo = atrasoDisparo;
            Instantiate(laser, transform.position, transform.rotation);
        }
    }
}
