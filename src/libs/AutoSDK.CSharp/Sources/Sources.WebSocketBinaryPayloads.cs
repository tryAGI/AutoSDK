using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    internal static ImmutableArray<PropertyData> GetWebSocketBinaryPayloadProperties(ModelData modelData)
    {
        if (modelData.Properties.IsDefaultOrEmpty)
        {
            return ImmutableArray<PropertyData>.Empty;
        }

        var builder = ImmutableArray.CreateBuilder<PropertyData>(modelData.Properties.Length);
        for (var i = 0; i < modelData.Properties.Length; i++)
        {
            var property = modelData.Properties[i];
            if (IsWebSocketBinaryPayloadProperty(property))
            {
                builder.Add(property);
            }
        }

        return builder.ToImmutable();
    }

    internal static string GetWebSocketBinaryPayloadBytesPropertyName(ModelData modelData, PropertyData property)
    {
        var candidate = property.Name + "Bytes";
        var existingNames = new HashSet<string>(modelData.Properties.Select(x => x.Name), StringComparer.OrdinalIgnoreCase);

        if (!existingNames.Contains(candidate))
        {
            return candidate;
        }

        for (var i = 2; ; i++)
        {
            candidate = property.Name + "Bytes" + i;
            if (existingNames.Add(candidate))
            {
                return candidate;
            }
        }
    }

    internal static bool IsStringBackedWebSocketBinaryPayloadProperty(PropertyData property)
    {
        return string.Equals(property.Type.CSharpTypeWithoutNullability, "string", StringComparison.Ordinal) &&
               IsWebSocketBinaryPayloadProperty(property);
    }

    private static bool IsWebSocketBinaryPayloadProperty(PropertyData property)
    {
        return property.Type.IsBase64 ||
               ContainsBase64Marker(property.Summary) ||
               ContainsBase64Marker(property.Description);
    }

    private static bool ContainsBase64Marker(string? value)
    {
        return !string.IsNullOrWhiteSpace(value) &&
               value.Contains("base64", StringComparison.OrdinalIgnoreCase);
    }
}
