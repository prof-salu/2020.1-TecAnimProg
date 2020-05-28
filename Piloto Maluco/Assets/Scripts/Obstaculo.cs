using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float distancia = 1.5f;

    private void Start()
    {
        transform.Translate(Vector3.up * Random.Range(-distancia, distancia));
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Barreira"))
        {
            Destroy(gameObject);
        }
    }
}
