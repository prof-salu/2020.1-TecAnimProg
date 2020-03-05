using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteWhile : MonoBehaviour
{
    public int energia = 10000;
    public bool estaNaLava = true;
    public int danoDaLava = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Antes do loop: Energia --> " + energia);
        while (estaNaLava == true)
        {
            energia = energia - danoDaLava;
            Debug.Log("Durante o loop: Energia --> " + energia);
            if(energia <= 0)
            {
                break;
            }
        }
        Debug.Log("Apos o loop: Energia --> " + energia);
    }
}
