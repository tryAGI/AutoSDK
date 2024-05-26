using System.Text.Json;
using OpenApiGenerator.Helpers.JsonEnumConverter;

namespace OpenApiGenerator.JsonConverters;

internal sealed class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
        => StringExtensions.ToSnakeCase(name);
}