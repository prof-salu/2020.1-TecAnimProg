using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteVetor : MonoBehaviour
{
    string item1 = "espada";
    string item2 = "mochila";
    string item3 = "lanterna";
    string item4 = "pocao de energia";

    string[] itens = new string[10];
    
    // Start is called before the first frame update
    void Start()
    {
        itens[0] = "espada";
        itens[1] = "mochila";
        itens[2] = "lanterna";
        itens[3] = "pocao de energia";
        itens[4] = "pocao de mana";
        itens[5] = "";
        itens[6] = "";
        itens[7] = "";
        itens[8] = "planta red rose";
        itens[9] = "";

        Debug.Log("Meus itens: ");

        //Debug.Log(itens[0]);
        //Debug.Log(itens[1]);
        //Debug.Log(itens[2]);
        //Debug.Log(itens[3]);
        //Debug.Log(itens[4]);

        foreach(string item in itens)
        {
            Debug.Log(item);
        }

        for(int i = 0; i < itens.Length; i++)
        {
            //Debug.Log(itens[i]);
            if(itens[i].Equals("planta makarov"))
            {
                Debug.Log("Voce possui a planta makarov!");
            }
        }
    }
}
