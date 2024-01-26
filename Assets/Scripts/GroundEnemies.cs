using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    public bool viradoParaDireita = true;

    void Update()
    {
        MoverInimigo();
    }

    void MoverInimigo()
    {
        float movimentoHorizontal = viradoParaDireita ? 1 : -1;

        // Movimento do inimigo
        transform.Translate(Vector2.right * movimentoHorizontal * velocidade * Time.deltaTime);

        // Verificar se o inimigo tocou em uma parede
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * movimentoHorizontal, 0.1f);

        if (hit.collider != null && hit.collider.tag == "Parede")
        {
            // Inverter a direção quando atingir uma parede
            viradoParaDireita = !viradoParaDireita;
            Flip();
        }
    }

    void Flip()
    {
        // Inverter a escala horizontal para mudar a direção do sprite
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
