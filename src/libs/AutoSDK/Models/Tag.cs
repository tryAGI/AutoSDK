using AutoSDK.Naming.Clients;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct Tag(
    string Name,
    string Description,
    Settings GlobalSettings,
    string SafeName,
    string SingularizedName
)
{
    public static Tag Empty => new(
        Name: string.Empty,
        Description: string.Empty,
        GlobalSettings: Settings.Default,
        SafeName: string.Empty,
        SingularizedName: string.Empty);

    public static Tag FromTag(OpenApiTagReference tag, Settings settings)
    {
        return FromTag(tag, settings, safeName: null);
    }

    public static Tag FromTag(OpenApiTagReference tag, Settings settings, string? safeName)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return Create(
            name: tag.Name ?? string.Empty,
            description: tag.Description ?? string.Empty,
            settings: settings,
            safeName: safeName);
    }

    public static Tag FromTag(OpenApiTag tag, Settings settings)
    {
        return FromTag(tag, settings, safeName: null);
    }

    public static Tag FromTag(OpenApiTag tag, Settings settings, string? safeName)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return Create(
            name: tag.Name ?? string.Empty,
            description: tag.Description ?? string.Empty,
            settings: settings,
            safeName: safeName);
    }

    private static Tag Create(
        string name,
        string description,
        Settings settings,
        string? safeName)
    {
        safeName ??= ClientNameGenerator.GeneratePropertyName(settings, name);

        return new Tag(
            Name: name,
            Description: description,
            GlobalSettings: settings,
            SafeName: safeName,
            SingularizedName: safeName.EndsWith("ies", StringComparison.OrdinalIgnoreCase)
                ? safeName.TrimEnd('s', 'e', 'i') + "y"
                : safeName.TrimEnd('s'));
    }
}
