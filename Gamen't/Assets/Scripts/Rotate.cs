using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 80 * Time.deltaTime, Space.Self);

    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Toque");
        Destroy(this.gameObject);

    }
}
