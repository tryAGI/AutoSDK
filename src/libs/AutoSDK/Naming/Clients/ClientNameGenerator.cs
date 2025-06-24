using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;

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

        var name = new string(tag.Name
            .SkipWhile(c => !char.IsDigit(c) && !char.IsLetter(c))
            .ToArray());
        
        return CSharpPropertyNameGenerator.SanitizeName(name.ToClassName(), settings.ClsCompliantEnumPrefix);
    }
    
    public static string GeneratePropertyName(
        Settings settings,
        Tag tag)
    {
        var name = new string(tag.Name
            .SkipWhile(c => !char.IsDigit(c) && !char.IsLetter(c))
            .ToArray());
        
        return CSharpPropertyNameGenerator.SanitizeName(name.ToClassName(), settings.ClsCompliantEnumPrefix);
    }
}