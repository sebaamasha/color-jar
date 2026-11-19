using TMPro;
using UnityEngine;

// CoinCounter.cs: on the coin text in the Home HUD
public class CoinCounter : MonoBehaviour
{
    [SerializeField] TMP_Text label; // drag the coin text here

    void Start() => Show();

    public void Add(int amount) // a button: On Click () → CoinCounter.Add, 10
    {
        Services.Save.SetInt("coins", Services.Save.GetInt("coins") + amount);
        Show();
    }

    void Show() => label.text = "Coins: " + Services.Save.GetInt("coins");
}