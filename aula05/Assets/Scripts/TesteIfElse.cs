using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteIfElse : MonoBehaviour
{
    public bool estaVivo = true;
    public bool pisandoNoFogo = false;

    // Start is called before the first frame update
    void Start()
    {
        if (estaVivo && !pisandoNoFogo)
        {
            Debug.Log("Pela horda!");
        }
        else if (estaVivo && pisandoNoFogo)
        {
            Debug.Log("Morreu tostado, saia de cima do fogo...");
        }

        else
        {
            Debug.Log("A aliança te pegou...");
        }

        /*
        if (estaVivo == true && pisandoNoFogo == false)
        {
            Debug.Log("Pela horda!");
        }
        else if (estaVivo == true && pisandoNoFogo == true)
        {
            Debug.Log("Morreu tostado, saia de cima do fogo...");
        }
        else
        {
            Debug.Log("A aliança te pegou...");
        }*/
    }
}
