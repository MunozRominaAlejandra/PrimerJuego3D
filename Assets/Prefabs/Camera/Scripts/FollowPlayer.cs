using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    #region Atributos
    private Vector3 offSet;
    private PlayerMovement playerMovement;
    #endregion

    #region
    private void Start()
    {
        offSet = new Vector3(0, 1, -5);
        playerMovement = FindFirstObjectByType<PlayerMovement>();
    }
    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet;
    }
    #endregion
}
