using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField] private float intervaloDeCriacao = 3;
    [SerializeField] private GameObject obstaculo;
    private float timerProximoObstaculo = 0;

    private void Start()
    {
        timerProximoObstaculo = intervaloDeCriacao;
    }

    private void Update()
    {
        timerProximoObstaculo -= Time.deltaTime;

        if(timerProximoObstaculo < 0)
        {
            Instantiate(obstaculo, transform.position, Quaternion.identity);
            timerProximoObstaculo = intervaloDeCriacao;
        }
    }
}
