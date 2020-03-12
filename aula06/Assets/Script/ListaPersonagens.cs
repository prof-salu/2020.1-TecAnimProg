using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaPersonagens : MonoBehaviour
{

    /* Crie um vetor onde possamos armazenar todos os nomes de todos os personagens do jogo 
     * Street Fighter II. Em seguida os imprima no console da Unity.*/

    string[] streetFighter = new string[12];
    string[] mortalKombat = {"Scorpion", "Sub Zero", "Raiden", "Sonya", "Liu Kang", "Jhonny Cage",
                                "Kano", "Goro", "Shang Tsung"};

    public string[] samuraiShodown = new string[12];

    // Start is called before the first frame update
    void Start()
    {
        streetFighter[0] = "Ryu";
        streetFighter[1] = "Ken";
        streetFighter[2] = "Blanka";
        streetFighter[3] = "E. Honda";
        streetFighter[4] = "Guile";
        streetFighter[5] = "Chun-li";
        streetFighter[6] = "Zangief";
        streetFighter[7] = "Dhalsim";
        streetFighter[8] = "M. Bison";
        streetFighter[9] = "Balrog";
        streetFighter[10] = "Sagat";
        streetFighter[11] = "Vega";

        Debug.Log("Stree Fighter");
        for(int i = 0; i < streetFighter.Length; i++)
        {
            Debug.Log(streetFighter[i]);
        }

        Debug.Log("Mortal Kombat");
        foreach(string personagens in mortalKombat){
            Debug.Log(personagens);
        }

        Debug.Log("Samurai Shodown");
        foreach (string personagens in samuraiShodown)
        {
            Debug.Log(personagens);
        }
    }
}
