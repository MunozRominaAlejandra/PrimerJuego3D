using UnityEngine;

public class ComandoMover : iCommand
{
    #region Atributos
    private readonly PlayerMovement playerMovement;
    private readonly float input;
    #endregion

    #region
    public ComandoMover(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    public void Execute()
    {
        playerMovement.SetStrategy(new MovimientoLateral());
        playerMovement.MovePlayer(input);
    }
    #endregion
}
