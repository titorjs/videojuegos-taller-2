using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 5f; // Velocidad de movimiento del jugador
    public static float rotationSpeed = 100f; // Velocidad de rotación del jugador

    // Update is called once per frame
    void Update()
    {
        // Avanzar constantemente hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Moverse a los lados con las teclas de dirección
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Girar como animación
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationAmount);
    }
}
