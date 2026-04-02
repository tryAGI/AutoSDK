namespace AutoSDK.Models;

public record struct EndPointResponse(
    string StatusCode,
    string Description,
    string MimeType,
    ContentType ContentType,
    TypeData Type,
    bool HasHeaders
)
{
    public bool Is1XX => StatusCode.StartsWith("1", StringComparison.OrdinalIgnoreCase);
    public bool Is2XX => StatusCode.StartsWith("2", StringComparison.OrdinalIgnoreCase);
    public bool Is3XX => StatusCode.StartsWith("3", StringComparison.OrdinalIgnoreCase);
    public bool Is4XX => StatusCode.StartsWith("4", StringComparison.OrdinalIgnoreCase);
    public bool Is5XX => StatusCode.StartsWith("5", StringComparison.OrdinalIgnoreCase);
    public bool IsDefault => StatusCode == "default";
    public bool IsPattern => StatusCode.Contains("XX");
    public int Min => int.TryParse(StatusCode.Replace("XX", "00"), out var code) ? code : 0;
    public int Max => int.TryParse(StatusCode.Replace("XX", "99"), out var code) ? code : 0;
    
    public static EndPointResponse Default => new(
        StatusCode: "200",
        Description: string.Empty,
        MimeType: string.Empty,
        ContentType: ContentType.String,
        Type: TypeData.Default,
        HasHeaders: false);
}
