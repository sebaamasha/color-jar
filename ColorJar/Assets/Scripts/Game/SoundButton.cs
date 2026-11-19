using TMPro;
using UnityEngine;

// SoundButton.cs: on the Sound button in Home. Flips SoundOn and shows it.
public class SoundButton : MonoBehaviour
{
    TMP_Text label;

    void Start()
    {
        label = GetComponentInChildren<TMP_Text>(); // the button's own text
        Show();
    }

    public void Flip() // On Click () → SoundButton.Flip
    {
        Services.Settings.SoundOn = !Services.Settings.SoundOn;
        Show();
    }

    void Show() => label.text = Services.Settings.SoundOn ? "Sound: On" : "Sound: Off";
}