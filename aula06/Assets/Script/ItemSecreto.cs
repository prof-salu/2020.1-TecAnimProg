using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSecreto : MonoBehaviour
{
    /*
        Em jogo temos um item especial chamado SORTE, ao ser coletado esse item pode assumir 
        três formas OURO que vale 20 pontos, DIAMANTE que vale 50 pontos ou PRATA que vale 10 pontos.
        Supondo que ao final de uma fase o jogador tenha coletado 50 itens do tipo SORTE, qual 
        poderia ser a sua pontuação final sabendo que o item PRATA tem 50% de chance de ser coletado,
        o item OURO tem 30% e o item DIAMANTE tem apenas 20% de chances?      
    */

    readonly int OURO = 20;
    readonly int PRATA = 10;
    readonly int DIAMANTE = 50;
    int placar = 0;
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            int sorteia = Random.Range(1, 101);

            if (sorteia >= 1 && sorteia <= 50)
            {
                //Item Prata
                placar = placar + PRATA;
            }
            else if (sorteia > 50 && sorteia <= 80)
            {
                //Item ouro
                placar = placar + OURO;
            }
            else
            {
                //ItemSecreto Diamante
                placar = placar + DIAMANTE;
            }
        }

        Debug.Log("Placar final: " + placar);
    }
}
