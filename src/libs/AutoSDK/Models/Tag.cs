namespace AutoSDK.Models;

public record struct Tag(
    string Name,
    string Description,
    string DisplayName,
    Settings GlobalSettings,
    string SafeName,
    string SingularizedName
)
{
    public static Tag Empty => new(
        Name: string.Empty,
        Description: string.Empty,
        DisplayName: string.Empty,
        GlobalSettings: Settings.Default,
        SafeName: string.Empty,
        SingularizedName: string.Empty);

}
