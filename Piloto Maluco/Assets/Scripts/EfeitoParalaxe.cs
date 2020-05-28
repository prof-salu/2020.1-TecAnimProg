using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoParalaxe : MonoBehaviour
{
    [SerializeField] private float velocidade = 5;

    private Vector3 posicaoInicial;
    private float larguraDaImagem;
    private float larguraRealDaImagem;
    private float escalaDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        larguraDaImagem = GetComponent<SpriteRenderer>().size.x;
        escalaDaImagem = transform.localScale.x;
        larguraRealDaImagem = larguraDaImagem * escalaDaImagem;
    }

    private void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade * Time.time, larguraRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
