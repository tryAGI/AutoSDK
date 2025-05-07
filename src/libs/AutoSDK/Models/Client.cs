using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct Client(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    ImmutableArray<PropertyData> Clients,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    ImmutableArray<string> Converters
)
{
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}";
    
    public string InterfaceFileNameWithoutExtension => $"{Namespace}.I{ClassName}";
}