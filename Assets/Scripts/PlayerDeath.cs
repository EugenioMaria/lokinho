using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
        void OnTriggerEnter2D(Collision2D colidiu)
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
}
