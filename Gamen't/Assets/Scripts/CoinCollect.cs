using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinText;

    private void Update()
    {
        UpdateUI();

        if(coins == 10){
            Win();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coins++;
            Debug.Log("Moeda coletada");

            Destroy(other.gameObject);
        }
    }

    private void UpdateUI()
    {
        coinText.text = "Moedas: " + coins;
    }

    public void Win()
    {
        SceneManager.LoadScene("Win Screen");
    }
}
