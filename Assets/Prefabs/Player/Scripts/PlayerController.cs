using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Atributos
    private PlayerMovement playerMovement;
    private List<iCommand> commands;
    #endregion

    #region
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        commands = new List<iCommand>();
    }

    // Update is called once per frame
    void Update()
    {
        commands.Clear();
        float horizontalInput = Input.GetAxis("Horizontal");
        commands.Add(new ComandoMover(playerMovement, horizontalInput));
        if (Input.GetKey(KeyCode.Space))
        {
            commands.Add(new ComandoAcelerar(playerMovement, horizontalInput));
        }
        foreach (iCommand command in commands)
        {
            command.Execute();
        }
    }
    #endregion
}
