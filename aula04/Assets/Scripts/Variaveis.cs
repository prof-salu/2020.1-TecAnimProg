using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    public int energia = 100;
    public string nome = "Heroi";
    public double forca = 45;
    public bool estaVivo = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Iniciando jogo");
        Debug.Log("Nome: " + nome);
        Debug.Log("Energia: " + energia);
        Debug.Log("Força: " + forca);
        Debug.Log("Esta vivo: " + estaVivo);
    }

    // Update is called once per frame
    void Update()
    {
        //Comentario de linha

        /*  comentario
            de varias
            linhas
         */
        //Debug.Log("executa a cada frame");
    }
}
