using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{/*Crie três variáveis que representam os atributos de um personagem de RPG 
    (força, stamina, agilidade, ...). 
    Em seguida imprima no console da Unity a média de poder deste personagem.
 */


    //Range(min, max) --> Os valores devem estar obrigatoriamente dentro da faixa

    [Range(1, 100)] public int forca;
    [Range(1, 100)] public int stamina;
    [Range(1, 100)] public int agilidade;
    [Range(1, 100)] public int inteligencia;
    [Range(1, 100)] public int sabedoria;
    [Range(1, 100)] public int armadura;
    int poderDeLuta;
    
    void Start()
    {
        poderDeLuta = (forca + stamina + agilidade + inteligencia + sabedoria + armadura) / 6;
        Debug.Log("Poder de luta do " + gameObject.name + " : " + poderDeLuta);
    }

}
