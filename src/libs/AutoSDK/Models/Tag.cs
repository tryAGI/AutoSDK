using AutoSDK.Naming.Clients;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct Tag(
    string Name,
    string Description,
    Settings GlobalSettings
)
{
    public string SafeName => ClientNameGenerator.GeneratePropertyName(GlobalSettings, this);
    public string SingularizedName => SafeName.EndsWith("ies", StringComparison.OrdinalIgnoreCase)
        ? SafeName.TrimEnd('s', 'e', 'i') + "y"
        : SafeName.TrimEnd('s');

    public static Tag Empty => new(
        Name: string.Empty,
        Description: string.Empty,
        GlobalSettings: Settings.Default);

    public static Tag FromTag(OpenApiTagReference tag, Settings settings)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        var value = new Tag(
            Name: tag.Name,
            Description: tag.Description ?? string.Empty,
            GlobalSettings: settings);

        return value;
    }

    public static Tag FromTag(OpenApiTag tag, Settings settings)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        var value = new Tag(
            Name: tag.Name,
            Description: tag.Description ?? string.Empty,
            GlobalSettings: settings);

        return value;
    }
}