using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct Client(
    string Id,
    string ClassName,
    string FileNameWithoutExtension,
    string InterfaceFileNameWithoutExtension,
    string BaseUrl,
    ImmutableArray<PropertyData> Clients,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    Settings GlobalSettings,
    ImmutableArray<string> Converters,
    bool HasOAuth2Support = false,
    bool HasIdempotencySupport = false
);
