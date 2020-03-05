using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteFor : MonoBehaviour
{
    public int energia = 1000;
    public int dano = 200;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Antes do loop: Energia --> " + energia);

        for(int i = 0; i < 3; i++)
        {
            energia = energia - dano;
            Debug.Log("Durante o loop: Energia --> " + energia);
        }

        Debug.Log("Apos o loop: Energia --> " + energia);
    }
}
