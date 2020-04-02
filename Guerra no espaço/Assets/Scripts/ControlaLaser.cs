using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaLaser : MonoBehaviour
{
    public float velMax = 7f;
    private float limiteDolaser = 0.5f;
    private float duracaoDisparo = 1.2f;

    void Update()
    {
        Vector3 posicao = transform.position;

        Vector3 velocidade = new Vector3(0, velMax * Time.deltaTime, 0);

        posicao += transform.rotation * velocidade;

        //Limite vertical

        //Topo
        if(posicao.y - limiteDolaser > Camera.main.orthographicSize)
        {
            //Debug.Log("Laser fora da cena (TOPO)");
            //Destroy(gameobjectDestruido);
            //Destroy(gameobjectDestruido, tempoAtraso);
            Destroy(this.gameObject, duracaoDisparo);
        }

        //Baixo
        if(posicao.y + limiteDolaser < -Camera.main.orthographicSize)
        {
            //Debug.Log("Laser fora da cena (BAIXO)");
            Destroy(this.gameObject, duracaoDisparo);
        }

        
        //Proporcao da cena
        float proporcaoCena = (float)Screen.width / (float)Screen.height;
        //Largura da camera
        float larguraCamera = Camera.main.orthographicSize * proporcaoCena;

        //Limite horizontal
        //Esquerda
        if (posicao.x - limiteDolaser > larguraCamera)
        {
            Destroy(this.gameObject, duracaoDisparo);
        }

        //Direita
        if(posicao.x + limiteDolaser < -larguraCamera)
        {
            Destroy(this.gameObject, duracaoDisparo);
        }

        transform.position = posicao;
    }
}
