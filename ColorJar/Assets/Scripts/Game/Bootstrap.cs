using UnityEngine;
using UnityEngine.SceneManagement;

// The only script in the Bootstrap scene, the first scene in the Scene List.
public class Bootstrap : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Services survives every scene change

        Services.Save = new PlayerPrefsSaveService();             // 1 · save
        Services.Settings = new SettingsService(Services.Save);   // 2 · settings, needs save

        Debug.Log("Bootstrap: services ready");
        SceneManager.LoadScene("Home"); // only now: the first screen
    }
}