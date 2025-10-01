using UnityEngine;
/// <summary>
/// Permite el comportamiento del movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{

    #region Atributos
    /// <summary>
    /// Fuerza utilizada para aplicar al jugador
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Representa el tiempo que ha transcurrido
    /// desde la última aplicación de fuerzas
    /// </summary>
    private float tiempoUltimaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo debe aplicarse la fuerza
    /// </summary>
    private float intervaloTiempo;
    #endregion

    #region Ciclo de vida del script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        fuerzaPorAplicar = new Vector3(0,0,300f);
        tiempoUltimaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        tiempoUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoUltimaFuerza = 0f;
        }
    }
    #endregion
}
