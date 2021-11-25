using UnityEngine;

public class GroundTile : MonoBehaviour
{
    groundSpawner groundSpawner;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<groundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }
}
