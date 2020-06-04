using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjudaClick : MonoBehaviour
{
    private SpriteRenderer render;

    private void Awake()
    {
        render = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Desaparecer();
        }
    }

    private void Desaparecer()
    {
        render.enabled = false;
    }
}
