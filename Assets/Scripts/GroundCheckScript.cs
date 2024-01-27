using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{
    private BoxCollider2D trigger;
    [SerializeField]private EnemyMovement enemie;
    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<BoxCollider2D>();
        if(enemie.movingRight) {
            transform.position = new Vector2(enemie.transform.position.x + 0.35f, enemie.transform.position.y);
        }
        else {
            transform.position = new Vector2(enemie.transform.position.x - 0.35f, enemie.transform.position.y);
        }
    }

    // Chamado quando há uma colisão.
    void OnTriggerEnter2D(Collider2D col)
    {
        // Verificar se colidiu com uma parede.
        if (col.gameObject.CompareTag("Ground"))
        {
            // Inverter a direção.
            enemie.movingRight = !enemie.movingRight;
            
            if(enemie.movingRight) {
                transform.position = new Vector2(enemie.transform.position.x + 0.35f, enemie.transform.position.y);
            }
            else {
                transform.position = new Vector2(enemie.transform.position.x - 0.35f, enemie.transform.position.y);
            }
        }
    }
}
