using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float distancia = 1.5f;
    private Pontuacao pontuacao;
    private Aviao aviao;
    private bool pontuei = false;

    private void Start()
    {
        transform.Translate(Vector3.up * Random.Range(-distancia, distancia));
        aviao = GameObject.FindObjectOfType<Aviao>();
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        MarcarPonto();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Barreira"))
        {
            Destroy(gameObject);
        }
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }

    public void MarcarPonto()
    {
        if(pontuei == false && this.transform.position.x < aviao.transform.position.x)
        {
            Debug.Log("Marcou ponto");
            pontuei = true;
            pontuacao.MarcarPonto();
        }
    }
}
