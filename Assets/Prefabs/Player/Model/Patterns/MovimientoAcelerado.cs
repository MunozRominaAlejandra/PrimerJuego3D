using UnityEngine;

public class MovimientoAcelerado : iMovementStrategy
{
    private float velocidadActual = 0f;
    public void Move(Transform transform, Player player, float direccion)
    {
        velocidadActual += direccion * player.Aceleracion * Time.deltaTime;
        player.Velocidad = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        transform.Translate(velocidadActual, 0, 0);
    }
}
