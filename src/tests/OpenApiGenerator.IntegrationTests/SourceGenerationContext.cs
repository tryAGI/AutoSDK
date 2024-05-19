using System.Text.Json.Serialization;

namespace OpenApiGenerator.IntegrationTests;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(FullResponse))]
[JsonSerializable(typeof(AsnResponse))]
[JsonSerializable(typeof(RangesResponse))]
[JsonSerializable(typeof(DomainsResponse))]
[JsonSerializable(typeof(AbuseResponse))]
[JsonSerializable(typeof(PrivacyResponse))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;