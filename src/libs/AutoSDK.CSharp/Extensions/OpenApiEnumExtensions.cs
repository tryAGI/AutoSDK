using System.Globalization;
using System.Text.Json.Nodes;
using AutoSDK.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Extensions;

public static class OpenApiEnumExtensions
{
    private static readonly char[] EnumSeparators =
        ['_', '-', ' ', '.'];

    public static string? GetDefaultValue(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        if (context.TypeData.CSharpType == "object?" ||
            context.Schema.Default is JsonArray or JsonObject ||
            context.TypeData.CSharpTypeNullability)
        {
            return string.Empty;
        }

        if (context.Schema.IsConst() && context.Schema.Default == null &&
            !context.TypeData.IsEnum &&
            !(context.Schema.Enum?.Any() ?? false))
        {
            return GetConstLiteral(context);
        }

        var defaultString = context.Schema.Default?.GetString();
        if ((context.Schema.Enum?.Any() ?? false) && context.Schema.Default is JsonValue && !string.IsNullOrWhiteSpace(defaultString))
        {
            var @enum = context.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return context.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if ((context.Schema.AnyOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AnyOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            var value = @enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result) ? result.Name : "";

            if (string.IsNullOrWhiteSpace(value))
            {
                if (context.Children
                    .Where(x => x.Hint is Hint.AnyOf)
                    .Any(x => x.Schema.Type == Microsoft.OpenApi.JsonSchemaType.String))
                {
                    value = context.Schema.Default.GetString();
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        return $"\"{value}\"";
                    }
                }

                return null;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + value;
        }
        if ((context.Schema.OneOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.OneOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if ((context.Schema.AllOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AllOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        var defaultStringValue = context.Schema.Default?.GetString();
        if (context.Schema.Default is JsonValue && !string.IsNullOrWhiteSpace(defaultStringValue))
        {
            if (context.Schema.Type != Microsoft.OpenApi.JsonSchemaType.String &&
                (context.Schema.AnyOf ?? []).All(x => x.Type != Microsoft.OpenApi.JsonSchemaType.String) &&
                (context.Schema.AllOf ?? []).All(x => x.Type != Microsoft.OpenApi.JsonSchemaType.String) &&
                (context.Schema.OneOf ?? []).All(x => x.Type != Microsoft.OpenApi.JsonSchemaType.String))
            {
                return null;
            }

            return $"\"{defaultStringValue}\"";
        }

        return context.Schema.Default?.GetString();
    }

    public static Dictionary<string, PropertyData> ComputeEnum(
        this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var @enum = (context.Schema.Enum ?? []).ComputeEnum(
            enumName: context.Id,
            description: context.Parameter?.Description ?? context.Schema.Description ?? string.Empty,
            context.Settings.ToEnumNamingSettings());

        if ((context.Schema.Extensions?.TryGetValue("x-enum-descriptions", out var descriptions) ?? false) &&
            OpenApiExtensions.TryGetExtensionJsonNode(descriptions) is JsonArray descriptionsArray)
        {
            var i = 0;
            foreach (var description in descriptionsArray)
            {
                if (description is JsonValue descValue && descValue.TryGetValue<string>(out var descString))
                {
                    @enum[@enum.Keys.ElementAt(i)] = @enum[@enum.Keys.ElementAt(i)] with
                    {
                        Summary = OpenApiExtensions.ClearForXml(descString),
                    };
                }
                i++;
            }
        }

        if ((context.Schema.Extensions?.TryGetValue("x-enum-varnames", out var varnames) ?? false) &&
            OpenApiExtensions.TryGetExtensionJsonNode(varnames) is JsonArray varnamesArray)
        {
            var i = 0;
            foreach (var varname in varnamesArray)
            {
                if (i < @enum.Count &&
                    varname is JsonValue varValue && varValue.TryGetValue<string>(out var varString) &&
                    !string.IsNullOrWhiteSpace(varString))
                {
                    @enum[@enum.Keys.ElementAt(i)] = @enum[@enum.Keys.ElementAt(i)] with
                    {
                        Name = varString.ToPropertyName(),
                    };
                }
                i++;
            }
        }

        if ((context.Schema.Extensions?.TryGetValue("x-fern-enum", out var fernEnum) ?? false) &&
            OpenApiExtensions.TryGetExtensionJsonNode(fernEnum) is { } fernEnumNode)
        {
            if (fernEnumNode is JsonArray fernEnumArray)
            {
                var i = 0;
                foreach (var item in fernEnumArray)
                {
                    if (i < @enum.Count && item is JsonObject itemObj)
                    {
                        ApplyFernEnumItem(itemObj, @enum, i);
                    }
                    i++;
                }
            }
            else if (fernEnumNode is JsonObject fernEnumObj)
            {
                foreach (var kvp in fernEnumObj.OrderBy(x => x.Key, StringComparer.Ordinal))
                {
                    if (kvp.Value is JsonObject itemObj && @enum.ContainsKey(kvp.Key))
                    {
                        var index = @enum.Keys.ToList().IndexOf(kvp.Key);
                        if (index >= 0)
                        {
                            ApplyFernEnumItem(itemObj, @enum, index);
                        }
                    }
                }
            }
        }

        return EnsureUniqueEnumMemberNamesCaseInsensitive(@enum);
    }

    public static Dictionary<string, PropertyData> ComputeEnum(
        this IList<JsonNode> @enum,
        string enumName,
        string description,
        CSharpSettings settings)
    {
        return @enum.ComputeEnum(
            enumName,
            description,
            settings.ToEnumNamingSettings());
    }

    public static Dictionary<string, PropertyData> ComputeEnum(
        this IList<JsonNode> @enum,
        string enumName,
        string description,
        EnumNamingSettings settings)
    {
        @enum = @enum ?? throw new ArgumentNullException(nameof(@enum));
        enumName = enumName ?? throw new ArgumentNullException(nameof(enumName));

        var values = new Dictionary<string, PropertyData>();
        for (var i = 0; i < @enum.Count; i++)
        {
            var value = ((JsonNode?)@enum[i]).ToEnumValue(
                description: description,
                settings);
            if (!string.IsNullOrWhiteSpace(value.Name) && !values.ContainsKey(value.Id))
            {
                values[value.Id] = value;
            }
        }

        var allContainEnumName = values.Count > 0;
        if (allContainEnumName)
        {
            foreach (var kvp in values)
            {
                if (kvp.Value.Name.IndexOf(enumName, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    allContainEnumName = false;
                    break;
                }
            }
        }

        if (allContainEnumName)
        {
            var keys = new List<string>(values.Keys);
            foreach (var key in keys)
            {
                var v = values[key];
                values[key] = v with
                {
                    Name = v.Name.Remove(
                        v.Name.IndexOf(enumName, StringComparison.OrdinalIgnoreCase),
                        enumName.Length).ToEnumValue(
                        description: description,
                        settings).Name,
                };
            }
        }

        return EnsureUniqueEnumMemberNamesCaseInsensitive(values);
    }

    public static PropertyData ToEnumValue(
        this JsonNode? any,
        string description,
        CSharpSettings settings)
    {
        return any.ToEnumValue(description, settings.ToEnumNamingSettings());
    }

    public static PropertyData ToEnumValue(
        this JsonNode? any,
        string description,
        EnumNamingSettings settings)
    {
        var id = any.GetString() ?? string.Empty;

        return id.ToEnumValue(description, settings);
    }

    public static PropertyData ToEnumValue(
        this string id,
        string description,
        CSharpSettings settings)
    {
        return id.ToEnumValue(description, settings.ToEnumNamingSettings());
    }

    public static PropertyData ToEnumValue(
        this string id,
        string description,
        EnumNamingSettings settings)
    {
        var name = id
            .ReplacePlusAndMinusOnStart()
            .ToPropertyName()
            .UseWordSeparator(EnumSeparators)
            .Replace("+", "Plus")
            .Replace("*", "Any")
            .Replace("[]", "Array")
            .Replace("'", string.Empty)
            .Replace(".", string.Empty)
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);
        if (name.Length > 0 &&
            char.IsDigit(name[0]))
        {
            name = (string.IsNullOrWhiteSpace(settings.ClsCompliantEnumPrefix)
                ? "_"
                : settings.ClsCompliantEnumPrefix) + name;
        }

        return (PropertyData.Default with
        {
            Id = id,
            Name = CSharpPropertyNameGenerator.SanitizeName(name, settings.ClsCompliantEnumPrefix),
            Summary = OpenApiExtensions.ClearForXml(ExtractEnumSummaryFromDescription(id, description)),
        }).WithCSharpParameterName();
    }

    public static string ExtractEnumSummaryFromDescription(string id, string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            return string.Empty;
        }

        var lines = description.Split(["\n"], StringSplitOptions.RemoveEmptyEntries);
        var line = lines.FirstOrDefault(line => line.Contains(id) && line.Contains(":"));

        if (line == null)
        {
            return string.Empty;
        }

        var index = line.IndexOf(':');
        return index >= 0
            ? line.Substring(index + 1).Trim()
            : line.Trim();
    }

    private static void ApplyFernEnumItem(JsonObject itemObj, Dictionary<string, PropertyData> @enum, int index)
    {
        var current = @enum[@enum.Keys.ElementAt(index)];

        string? nameOverride = null;
        if (itemObj.TryGetPropertyValue("name", out var nameNode) &&
            nameNode is JsonValue nameValue && nameValue.TryGetValue<string>(out var nameStr) &&
            !string.IsNullOrWhiteSpace(nameStr))
        {
            nameOverride = nameStr.ToPropertyName();
        }
        else if (itemObj.TryGetPropertyValue("casing", out var casingNode) &&
                 casingNode is JsonObject casingObj &&
                 casingObj.TryGetPropertyValue("pascal", out var pascalNode) &&
                 pascalNode is JsonValue pascalValue && pascalValue.TryGetValue<string>(out var pascalStr) &&
                 !string.IsNullOrWhiteSpace(pascalStr))
        {
            nameOverride = pascalStr.ToPropertyName();
        }

        string? descriptionOverride = null;
        if (itemObj.TryGetPropertyValue("description", out var descNode) &&
            descNode is JsonValue descValue && descValue.TryGetValue<string>(out var descStr) &&
            !string.IsNullOrWhiteSpace(descStr))
        {
            descriptionOverride = OpenApiExtensions.ClearForXml(descStr);
        }

        @enum[@enum.Keys.ElementAt(index)] = current with
        {
            Name = nameOverride ?? current.Name,
            Summary = descriptionOverride ?? current.Summary,
        };
    }

    private static Dictionary<string, PropertyData> EnsureUniqueEnumMemberNamesCaseInsensitive(
        Dictionary<string, PropertyData> values)
    {
        if (values.Count <= 1)
        {
            return values;
        }

        var usedNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var suffixes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var result = new Dictionary<string, PropertyData>(values.Count, StringComparer.Ordinal);

        foreach (var kvp in values)
        {
            var property = kvp.Value;
            if (usedNames.Add(property.Name))
            {
                result[kvp.Key] = property;
                continue;
            }

            suffixes.TryGetValue(property.Name, out var suffix);
            suffix = Math.Max(suffix, 1);

            string candidateName;
            do
            {
                suffix++;
                candidateName = $"{property.Name}{suffix}";
            }
            while (!usedNames.Add(candidateName));

            suffixes[property.Name] = suffix;
            result[kvp.Key] = (property with
            {
                Name = candidateName,
            }).WithCSharpParameterName();
        }

        return result;
    }

    private static string? GetConstLiteral(SchemaContext context)
    {
        var constValue = context.Schema.Const;
        if (constValue == null)
        {
            return null;
        }

        return context.TypeData.CSharpTypeWithoutNullability switch
        {
            "string" => $"\"{constValue.ClearForCSharp()}\"",
            "bool" when bool.TryParse(constValue, out var value) => value ? "true" : "false",
            "byte" when byte.TryParse(constValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture),
            "short" when short.TryParse(constValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture),
            "int" when int.TryParse(constValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture),
            "long" when long.TryParse(constValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture) + "L",
            "float" when float.TryParse(constValue, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture) + "F",
            "double" when double.TryParse(constValue, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) => value.ToString("R", CultureInfo.InvariantCulture),
            "decimal" when decimal.TryParse(constValue, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) => value.ToString(CultureInfo.InvariantCulture) + "M",
            _ => null,
        };
    }
}
