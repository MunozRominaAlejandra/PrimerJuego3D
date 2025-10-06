using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
