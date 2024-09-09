using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Clients;

public static class ClientNameGenerator
{
    public static string Generate(
        Settings settings,
        OpenApiTag tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return $"{GeneratePropertyName(settings, tag)}Client";
    }
    
    public static string GeneratePropertyName(
        Settings settings,
        OpenApiTag tag)
    {
        tag = tag ?? throw new ArgumentNullException(nameof(tag));

        return PropertyData.SanitizeName(tag.Name.ToClassName(), settings.ClsCompliantEnumPrefix);
    }
}