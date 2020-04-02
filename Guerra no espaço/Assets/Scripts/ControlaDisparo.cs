using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaDisparo : MonoBehaviour
{
    public GameObject laser;
    public float atrasoNoDisparo = 0.5f;
    private float timerDisparo = 0;
    void Update()
    {
        timerDisparo -= Time.deltaTime;
        
        if (Input.GetButtonDown("Fire1") && timerDisparo <= 0)
        {
            //Debug.Log(Time.deltaTime);
            //Botao esquerdo do mouse
            //Debug.Log("Fire 1");
            //laser.SetActive(false);
            //Instantiate(gameobject, posicao, rotacao);

            timerDisparo = atrasoNoDisparo;
            Instantiate(laser, transform.position, transform.rotation);


        }

        if (Input.GetButtonDown("Fire2"))
        {
            //Botao direito do mouse
            //Debug.Log("Fire 2");
            //laser.SetActive(true);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            //Botao do meio do mouse
            //Debug.Log("Fire3");
        }

    }
}
