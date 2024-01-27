using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTexto : MonoBehaviour
{
    [SerializeField] private ChatBubble chat;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            if(coroutine == null)
            {
                coroutine = showChat(col);
                StartCoroutine(coroutine);
            }
        }
    }

    public IEnumerator showChat(Collider2D col)
    {
        chat = col.transform.Find("ChatBubble").GetComponent<ChatBubble>();
        chat.gameObject.SetActive(true);
        chat.Setup("BORAAAA");
        yield return new WaitForSeconds(5);
        chat.gameObject.SetActive(false);
        coroutine = null;
    }
}
