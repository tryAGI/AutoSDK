namespace OpenApiGenerator.Cli;

public static class Helpers
{
    public static string GetSettingsFolder()
    {
        var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenApiGenerator.Cli");
        Directory.CreateDirectory(folder);

        return folder;
    }
}