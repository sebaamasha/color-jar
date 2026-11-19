using UnityEngine;
using UnityEngine.SceneManagement;

// Put it on an empty GameObject in each scene, e.g. one called "ScreenFlow".
public class ScreenFlow : MonoBehaviour
{
    public void Play()   // Play button → On Click () → ScreenFlow.Play
    {
        SceneManager.LoadScene("Level"); // the exact scene name
    }

    public void Back()   // Back button → On Click () → ScreenFlow.Back
    {
        SceneManager.LoadScene("Home");
    }
}