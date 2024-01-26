using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referência ao transform do jogador/personagem
    public float smoothSpeed = 0.125f; // Velocidade suavizada de movimento da câmera
    public float offsetX = 0f; // Distância horizontal entre a câmera e o jogador

    void LateUpdate()
    {
        if (target != null)
        {
            float desiredX = target.position.x + offsetX;
            Vector3 desiredPosition = new Vector3(desiredX, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
