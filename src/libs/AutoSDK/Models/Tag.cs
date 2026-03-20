using AutoSDK.Extensions;
using AutoSDK.Naming.Clients;
using Microsoft.OpenApi;

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
            displayName: string.Empty,
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

        // Extract x-displayName from tag extensions
        var displayName = string.Empty;
        if (OpenApiExtensions.TryGetExtensionStringValue(
                tag.Extensions, "x-displayName", out var displayNameValue))
        {
            displayName = displayNameValue;
        }

        return Create(
            name: tag.Name ?? string.Empty,
            description: tag.Description ?? string.Empty,
            displayName: displayName,
            settings: settings,
            safeName: safeName);
    }

    public static Tag Create(string name, Settings settings)
    {
        return Create(name, description: string.Empty, displayName: string.Empty, settings, safeName: null);
    }

    private static Tag Create(
        string name,
        string description,
        string displayName,
        Settings settings,
        string? safeName)
    {
        safeName ??= ClientNameGenerator.GeneratePropertyName(settings, name);

        return new Tag(
            Name: name,
            Description: description,
            DisplayName: displayName,
            GlobalSettings: settings,
            SafeName: safeName,
            SingularizedName: safeName.EndsWith("ies", StringComparison.OrdinalIgnoreCase)
                ? safeName.TrimEnd('s', 'e', 'i') + "y"
                : safeName.TrimEnd('s'));
    }
}
