using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTexto : MonoBehaviour
{
    [SerializeField] private ChatBubble chat;
    private IEnumerator coroutine;
    private string areaText;
    private string[] texts = new string[30];
    
    void Start()
    {
        texts[0] = "Vai noob, pede pra nerfar!";
        texts[1] = "E lá vamos nós…";
        texts[2] = "Eu não quero acreditar que você falhou de novo";
        texts[3] = "POR QUE????";
        texts[4] = "Quase me esqueci que você é só um camponês";
        texts[5] = "Quanta habilidade";
        texts[6] = "Uma falha inesquecível, maravilhosa e inovadora";
        texts[7] = "Preciso que você use uma parte sua, uma parte mais racional";
        texts[8] = "Você consegue ficar abaixo das minhas expectativas";
        texts[9] = "Eu não esperava muito de você, mas CACET…";
        texts[10] = "Nem nota 5 vale, com boa vontade um 2?";
        texts[11] = "Xoxo, capenga, manco, anêmico, frágil e molenga…";
        texts[12] = "Eita, isso deve ter doído, FAZ DE NOVO!?!";
        texts[13] = "É para passar pelos desafios, E NÃO CAIR NELES!!";
        texts[14] = "Era pra estar contando?? Nah, eu perderia a conta mesmo";
        texts[15] = "Você está acostumado com o modo fácil?";
        texts[16] = "Você está ciente que não existe “modo fácil”, né?";
        texts[17] = "Se eu tivesse mãos, te daria um tapa na cara";
        texts[18] = "Por favor, PARE DE MORRER!";
        texts[19] = "Como é o clima no pós vida? Eu nunca estive lá pra saber.";
        texts[20] = "Acho que vou chorar";
        texts[21] = "Tá achando difícil? Chama seu irmão mais velho!";
        texts[22] = "CA - RA - L…";
        texts[23] = "HEY, CUIDADO COM O… deixa pra lá";
        texts[24] = "Você nasceu ruím ou fez bacharel?";
        texts[25] = "Agora vai ficar 2 anos na fila do SUS!";
        texts[26] = "Por que eu não fui cair perto de um Guerreiro";
        texts[27] = "Minha nossa nossa nossa";
        texts[28] = "Fazendo cosplay de rainha da inglaterra?";
        texts[29] = "EEEUU!! PARADO NO BAILÃO! ELA COM PO… Ah você morreu…";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {   
        System.Random rnd = new System.Random();
        int i  = rnd.Next(0, 29);
        areaText = texts[i];
        
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
