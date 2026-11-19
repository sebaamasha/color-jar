// SettingsService.cs: settings saved through ISaveService, never PlayerPrefs directly
public class SettingsService : ISettingsService
{
    const string SoundKey = "sound_on";
    readonly ISaveService save;

    public SettingsService(ISaveService save)
    {
        this.save = save;
    }

    public bool SoundOn
    {
        get => save.GetInt(SoundKey, 1) == 1;  // sound is on by default
        set => save.SetInt(SoundKey, value ? 1 : 0);
    }
}