using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().Restart();
        }

    }
}