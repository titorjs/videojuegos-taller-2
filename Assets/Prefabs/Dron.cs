using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dron : MonoBehaviour
{
    public static int coins = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Colisión con una moneda");
            Destroy(other.gameObject);
            coins++;
        }
        else if (other.CompareTag("Obstaculo"))
        {
            Debug.Log("Colisión con un obstáculo");
            // Agrega aquí cualquier lógica adicional para manejar la colisión con el obstáculo
        }
    }
}
