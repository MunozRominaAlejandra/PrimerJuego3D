using UnityEngine;

public class EjemploInvokes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("MensajeUnico", 5f);

        InvokeRepeating("MensajesContinuos", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MensajeUnico()
    {
        Debug.Log("Ejecutando luego de 5 segundos");
    }
    public void MensajesContinuos()
    {
        Debug.Log("Programación de videojuegos I");
    }
}
