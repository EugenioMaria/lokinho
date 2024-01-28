using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool movingRight = true;
    private Rigidbody2D rig;
    private BoxCollider2D trigger;

    void Start()
    {
        trigger = GetComponent<BoxCollider2D>();
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
    /*void OnTriggerEnter2D(Collision2D colidiu)
    {
        if (colidiu.gameObject.CompareTag("Player"))
        {
           ReiniciarPartida();
           Debug.Log ("Reinciando Cena");
        }
    }

    private void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
}
