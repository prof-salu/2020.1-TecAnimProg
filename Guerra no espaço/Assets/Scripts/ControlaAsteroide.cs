using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAsteroide : MonoBehaviour
{
    public AudioClip somAsteroide;
    public float velDeslocamento = 5;
    public float velRotacao = 180;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Encostou no colisor");
        if(collision.CompareTag("Laser"))
        {
            //Toca o som da explosão
            ControlaAudio.Instancia.PlayOneShot(somAsteroide);
            //Destroi o asteroide
            Destroy(this.gameObject);
            //Destro o laser
            Destroy(collision.gameObject);
        }
    }
        
    private void Update()
    {
        //Rotacao
        Quaternion rotacao = transform.rotation;

        float eixoZ = rotacao.eulerAngles.z;

        eixoZ += velRotacao * Time.deltaTime;

        rotacao = Quaternion.Euler(0, 0, eixoZ);

        transform.rotation = rotacao;

        //Deslocamento
        Vector3 posicao = transform.position;

        Vector3 velocidade = new Vector3(0, velDeslocamento * Time.deltaTime, 0);

        posicao -= velocidade;

        transform.position = posicao;

    }
}
