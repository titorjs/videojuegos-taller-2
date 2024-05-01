using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstaculo : MonoBehaviour
{
    public TMP_Text gans;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gans.SetText("Perdiste, tu puntaje final es: " + Dron.coins);
            Player.speed = 0;
            Player.rotationSpeed = 0;
        }
    }
}
