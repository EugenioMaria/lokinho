using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool movingRight = true;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    // Atualizado a cada frame.
    void FixedUpdate()
    {
        if (movingRight)
        {
            rig.velocity = new Vector2(speed, rig.velocity.y);
        }
        else
        {
            rig.velocity = new Vector2(-speed, rig.velocity.y);
        }
    }
}
