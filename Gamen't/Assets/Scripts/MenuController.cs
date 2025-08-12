using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
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

    public void BtnExit()
    {
        Application.Quit();
    }
}
