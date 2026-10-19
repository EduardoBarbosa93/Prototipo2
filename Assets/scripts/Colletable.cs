using UnityEngine;

public class Colletable : MonoBehaviour
{
    public int valor = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
