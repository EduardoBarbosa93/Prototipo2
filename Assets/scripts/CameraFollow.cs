using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; // Referência ao objeto que a câmera vai seguir

    public Vector3 deslocamento = new Vector3(0f, 5f, -10f);

    public float suavizacao = 5f; // Quanto mais baixo, mais suave será o movimento da câmera

    private void LateUpdate()
    {
        Vector3 PosicaoDesejada = alvo.position + deslocamento;
        transform.position = Vector3.Lerp(transform.position, PosicaoDesejada, suavizacao * Time.deltaTime);
        transform.LookAt(alvo); // Faz a câmera olhar para o alvo.
    }

}
