using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTexto : MonoBehaviour
{
    [SerializeField] private ChatBubble chat;
    private IEnumerator coroutine;
    public string areaText;
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
            }else{
                StopCoroutine(coroutine);
                coroutine = null;
                coroutine = showChat(col);
                StartCoroutine(coroutine);
            }
        }
    }

    public IEnumerator showChat(Collider2D col)
    {
        chat = col.transform.Find("ChatBubble").GetComponent<ChatBubble>();
        chat.gameObject.SetActive(true);
        chat.Setup(areaText);
        yield return new WaitForSeconds(5);
        chat.gameObject.SetActive(false);
        coroutine = null;
    }
}
