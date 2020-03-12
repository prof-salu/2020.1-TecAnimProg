using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combatentes : MonoBehaviour
{
    [Range(0, 100)] public int poderAtaque;
    [Range(0, 100)] public int poderDefesa;
    [Range(0, 300)] public int resistencia;

    public void ExibeInformacao()
    {
        Debug.Log(gameObject.name + " - Poder de ataque: " + poderAtaque);
        Debug.Log(gameObject.name + " - Poder de defesa: " + poderDefesa);
        Debug.Log(gameObject.name + " - Resistencia: " + resistencia);
    }

    public void Atacar(Combatentes inimigo)
    {
        double multAtaque = Random.Range(0.5f, 1.5f);
        int danoFinal = (int) ((poderAtaque - inimigo.poderDefesa) * multAtaque);
        inimigo.resistencia = (inimigo.resistencia - danoFinal);
    }

    public bool EstaVivo()
    {
        if(resistencia > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
