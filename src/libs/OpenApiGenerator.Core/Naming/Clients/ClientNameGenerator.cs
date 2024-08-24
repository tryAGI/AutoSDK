using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Naming.Clients;

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