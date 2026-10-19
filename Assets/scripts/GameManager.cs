using UnityEngine;
using TMPro;


public class GerenciadordeJogo : MonoBehaviour
{
    public static GerenciadordeJogo instancia;
    public TextMeshProUGUI textoPontuacao;
   
    private int pontuacao = 0;

    void Awake()
    {
        instancia = this;
    }

    private void Start()
    {
        AtualizarTexto();
    }

    public void AdicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        textoPontuacao.text = "Gatinhos: " + pontuacao;
    }
}
