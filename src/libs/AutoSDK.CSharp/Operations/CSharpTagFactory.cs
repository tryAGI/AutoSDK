using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class CSharpTagFactory
{
    public static Tag FromTag(OpenApiTagReference tag, CSharpSettings settings)
    {
        return FromTag(tag, settings, safeName: null);
    }

    public static Tag FromTag(OpenApiTagReference tag, CSharpSettings settings, string? safeName)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return Create(
            name: tag.Name ?? string.Empty,
            description: tag.Description ?? string.Empty,
            displayName: string.Empty,
            settings: settings,
            safeName: safeName);
    }

    public static Tag FromTag(OpenApiTag tag, CSharpSettings settings)
    {
        return FromTag(tag, settings, safeName: null);
    }

    public static Tag FromTag(OpenApiTag tag, CSharpSettings settings, string? safeName)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

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

    public static Tag Create(string name, CSharpSettings settings)
    {
        return Create(name, description: string.Empty, displayName: string.Empty, settings, safeName: null);
    }

    private static Tag Create(
        string name,
        string description,
        string displayName,
        CSharpSettings settings,
        string? safeName)
    {
        safeName ??= CSharpClientNameGenerator.GeneratePropertyName(settings, name);

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
