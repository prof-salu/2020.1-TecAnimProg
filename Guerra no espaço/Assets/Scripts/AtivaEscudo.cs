using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AtivaEscudo : MonoBehaviour
{
    private float timerAtivacao = 0f;
    public float timerRecargaEscudo = 20f;
    private GameObject jogador;
    public GameObject escudoPrefab;
    
    void Start()
    {
        jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        timerAtivacao -= Time.deltaTime;
        
        if(Input.GetKeyDown(KeyCode.Space) && timerAtivacao <= 0)
        {
            timerAtivacao = timerRecargaEscudo;
            GameObject escudo = Instantiate(escudoPrefab, transform.position, transform.rotation);
            escudo.transform.parent = jogador.transform;
        }
    }
}