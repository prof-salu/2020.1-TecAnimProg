using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Combatentes lut1;
    public Combatentes lut2;

    void Start()
    {
        lut1.ExibeInformacao();
        lut2.ExibeInformacao();

        Debug.Log("Fight");
        
        for(int i = 0; i < 30; i++)
        {
            lut1.Atacar(lut2);

            if(lut2.EstaVivo() == false)
            {
                Debug.Log("Rodada: " + (i + 1));
                break;
            }

            lut2.Atacar(lut1);

            if(lut1.EstaVivo() == false)
            {
                Debug.Log("Rodada: " + (i + 1));
                break;
            }
        }

        Debug.Log("Fim de luta...");
        lut1.ExibeInformacao();
        lut2.ExibeInformacao();
    }
}
