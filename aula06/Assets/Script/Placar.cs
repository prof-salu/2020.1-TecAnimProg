using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placar : MonoBehaviour
{
    /*Ao terminar uma fase de um jogo de tiro é preciso exibir a nota final do jogador 
     * em uma escala de A à F (imprima a nota no console da Unity), 
     * onde A é a melhor nota e F a pior nota. A nota é exibida baseada em sua pontuação 
     * final, onde:
        - F pontuação <= 25000
        - E pontuação > 25000
        - D pontuação > 40000
        - C pontuação > 60000
        - B pontuação > 80000
        - A pontuação > 100000
    */
    [Range(1, 150000)]
    public int pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        if (pontuacao > 100000)
        {
            Debug.Log("Nota A");
        }
        else if (pontuacao > 80000)
        {
            Debug.Log("Nota B");
        }
        else if (pontuacao > 60000)
        {
            Debug.Log("Nota C");
        }
        else if (pontuacao > 40000)
        {
            Debug.Log("Nota D");
        }
        else if (pontuacao > 25000)
        {
            Debug.Log("Nota E");
        }
        else
        {
            Debug.Log("Nota F");
        }
    }

}
