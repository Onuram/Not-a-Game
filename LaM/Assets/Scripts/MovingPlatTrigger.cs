using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatTrigger : MonoBehaviour
{
    private MovingPlat platform;

    void Awake()
    {
        platform = GetComponentInParent<MovingPlat>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rbPlayer = other.attachedRigidbody;
            if (rbPlayer != null)
            {
                rbPlayer.position += platform.delta;
            }
        }
    }

}
