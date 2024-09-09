using System.Text.Json;
using AutoSDK.Helpers.JsonEnumConverter;

namespace AutoSDK.JsonConverters;

internal sealed class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
        => StringExtensions.ToSnakeCase(name);
}