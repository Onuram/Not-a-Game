using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MovingPlat : MonoBehaviour
{
    public Vector3 movement = new Vector3(5, 0, 0);
    public float time = 2f;
    private Rigidbody rb;
    private Vector3 origin, target;
    private Vector3 lastPosition;
    public Vector3 delta;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        origin = transform.position;
        target = origin + movement;
        lastPosition = origin;
    }

    void FixedUpdate()
    {
        float t = Mathf.PingPong(Time.time / time, 1f);
        Vector3 newPos = Vector3.Lerp(origin, target, t);

        delta = newPos - lastPosition;
        rb.MovePosition(newPos);
        lastPosition = newPos;
    }

}
