using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinText;

    private void Update()
    {
        UpdateUI();
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
}
