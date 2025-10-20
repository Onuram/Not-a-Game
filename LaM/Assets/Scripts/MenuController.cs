using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BtnStart()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void BtnSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BtnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BtnMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BtnExit()
    {
        Application.Quit();
    }
}
