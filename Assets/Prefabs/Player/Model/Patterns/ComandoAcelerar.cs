using UnityEngine;

public class ComandoAcelerar : iCommand
{
    #region Atributos
    private readonly PlayerMovement playerMovement;
    private readonly float input;
    #endregion

    #region
    public ComandoAcelerar(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    public void Execute()
    {
        playerMovement.SetStrategy(new MovimientoAcelerado());
        playerMovement.MovePlayer(input);
    }
    #endregion
}
