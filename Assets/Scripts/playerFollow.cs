using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public RotationDriveMode rotation;

    void Update()
    {
        transform.position = player.position + offset;
    }
}
