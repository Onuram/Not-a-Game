using UnityEngine;

public class GhostController : MonoBehaviour
{
    public LayerMask obstructionLayer;
    public Transform target;
    public Camera playerCamera;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public float viewAngleThreshold = 60f;
    private Quaternion _lookRotation;
    private Vector3 _direction;


    void Update()
    {
        bool inLineOfSight = IsInLineOfSight();

        if (target == null || playerCamera == null) return;

        Vector3 dirToGhost = (transform.position - playerCamera.transform.position).normalized;
        float angle = Vector3.Angle(playerCamera.transform.forward, dirToGhost);
        bool isSeen = angle < viewAngleThreshold;

        _direction = (target.position - transform.position).normalized;
        _lookRotation = Quaternion.LookRotation(_direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation,
            Time.deltaTime * rotationSpeed);

        if (!isSeen || !inLineOfSight)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                target.position, speed * Time.deltaTime);
        }
    }
    
    bool IsInLineOfSight()
    {
        Vector3 directionToTarget = (transform.position - target.position).normalized;
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        RaycastHit hit;

        if (Physics.Raycast(target.position, directionToTarget, out hit, distanceToTarget, obstructionLayer))
        {
            if (hit.collider.transform != this.transform)
            {
                return false;
            }
        }
        return true; 
    }
}
