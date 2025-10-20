using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Lose Screen");
        }
    }
}
