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
            Debug.Log("Colisi�n con una moneda");
            Destroy(other.gameObject);
            coins++;
        }
        else if (other.CompareTag("Obstaculo"))
        {
            Debug.Log("Colisi�n con un obst�culo");
            // Agrega aqu� cualquier l�gica adicional para manejar la colisi�n con el obst�culo
        }
    }
}
