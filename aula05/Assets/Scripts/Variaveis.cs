using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    //Comentarios de linha

    /*  Comentario 
          de
        bloco
    */

    //Variaveis

    //no C# o tipo string e escrito em minusculo
    string nome = "Guerreiro";
    public int forca = 70;
    public long armadura = 3500;
    public float dano = 2.75f;
    bool modoDefensivo = false;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Executado no primeiro frame");
        Debug.Log("Nome: " + nome);
        Debug.Log("Forca: " + forca);
        Debug.Log("Armadura: " + armadura);
        Debug.Log("Dano: " + dano);
        Debug.Log("Modo defensivo: " + modoDefensivo);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Executando a cada frame");
    }
}
