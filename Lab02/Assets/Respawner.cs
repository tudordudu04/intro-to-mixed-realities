using UnityEngine;

public class Respawner : MonoBehaviour
{
    public Transform player;
    public float maxDistance = 10f;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Rigidbody rb;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > maxDistance)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}