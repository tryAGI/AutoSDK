using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct Client(
    string Id,
    string ClassName,
    string BaseUrl,
    ImmutableArray<PropertyData> Clients,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    Settings GlobalSettings,
    ImmutableArray<string> Converters
)
{
    public string FileNameWithoutExtension => $"{Settings.Namespace}.{ClassName}";
    
    public string InterfaceFileNameWithoutExtension => $"{Settings.Namespace}.I{ClassName}";
}