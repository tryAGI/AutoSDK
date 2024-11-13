namespace AutoSDK.CLI;

internal static class Helpers
{
    public static string GetSettingsFolder()
    {
        var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AutoSDK.CLI");
        Directory.CreateDirectory(folder);

        return folder;
    }
}