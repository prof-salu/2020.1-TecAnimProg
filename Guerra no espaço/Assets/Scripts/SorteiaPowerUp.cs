using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorteiaPowerUp : MonoBehaviour
{
    void Start()
    {
        int sorteiaPowerup = Random.Range(0, 3);
        transform.GetChild(sorteiaPowerup).gameObject.SetActive(true);
    }
}
