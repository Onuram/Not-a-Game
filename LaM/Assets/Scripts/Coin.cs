using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(0, 0, 80 * Time.deltaTime, Space.Self);

    }

}
