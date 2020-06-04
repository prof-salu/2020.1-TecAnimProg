using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogo : MonoBehaviour
{
    [SerializeField] GameOver gameOver;
    [SerializeField] Aviao aviao;
    [SerializeField] private Pontuacao pontuacao;
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        pontuacao.SalvarPontuacao();
        gameOver.ExibirInterface();
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;
        gameOver.EsconderInterface();
        aviao.Reiniciar();
        DestruirObstaculos();
        pontuacao.ResetarPlacar();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();

        //for (int i = 0; i < obstaculos.Length; i++)
        //{
           // obstaculos[i].Destruir();
        //}

        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
