using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fin : MonoBehaviour
{
    public TMP_Text ganasteText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ganasteText.SetText("Ganaste, tu puntaje final es: " + Dron.coins);
            Player.speed = 0;
            Player.rotationSpeed = 0;
        }
    }
}
