using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField] private float impulso = 6;
    [SerializeField] private ControlaJogo controlaJogo;
    private Rigidbody2D rigidbody;
    private Vector3 posicaoInicial;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.AddForce(Vector2.up * impulso, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.simulated = false;
        controlaJogo.FinalizarJogo();
    }

    public void Reiniciar()
    {
        transform.position = posicaoInicial;
        rigidbody.simulated = true;
    }
}
