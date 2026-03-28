using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContext(
        Client client,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!client.Settings.FromCli ||
            !client.Settings.ShouldGenerateJsonSerializerContextTypes())
        {
            return string.Empty;
        }

        // Extract class name from fully-qualified JsonSerializerContext setting
        var contextClassName = client.Settings.JsonSerializerContext.Contains(".")
            ? client.Settings.JsonSerializerContext.Substring(client.Settings.JsonSerializerContext.LastIndexOf('.') + 1)
            : "SourceGenerationContext";
        
        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {client.Settings.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {{
{client.Converters.Select(x => $@"
            typeof({x}),
").Inject()}
        }})]
{(types.IsEmpty ? TrimmedLine : GenerateJsonSerializableAttributes(client, types))}
    public sealed partial class {contextClassName} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateJsonSerializableAttributes(
        Client client,
        EquatableArray<TypeData> types)
    {
        var distinctTypes = types
            .Select(x => x.CSharpTypeWithoutNullability)
            .Distinct()
            .ToArray();

        var concreteListTypes = GetConcreteListTypes(distinctTypes);
        var serializableTypes = new[]
        {
            $"global::{client.Settings.Namespace}.JsonSerializerContextTypes",
        }
            .Concat(distinctTypes)
            .Concat(concreteListTypes)
            .ToArray();

        // Value types with nullable variants in JsonSerializerContextTypes will be
        // implicitly discovered by STJ through the nullable property (T? → Nullable<T> → T).
        // This causes SYSLIB1031 when the same type is also explicitly registered.
        var implicitlyDiscoveredTypes = new HashSet<string>(
            types
                .Where(x => x.CSharpTypeWithNullability != x.CSharpTypeWithoutNullability &&
                            x.CSharpTypeWithNullability.EndsWith("?", StringComparison.Ordinal))
                .Select(x => x.CSharpTypeWithoutNullability)
                .Distinct(),
            StringComparer.Ordinal);

        var explicitTypeInfoPropertyNames = BuildExplicitTypeInfoPropertyNames(
            serializableTypes, implicitlyDiscoveredTypes);

        var attributes = new List<string>(serializableTypes.Length);

        foreach (var type in serializableTypes)
        {
            explicitTypeInfoPropertyNames.TryGetValue(type, out var typeInfoPropertyName);
            attributes.Add(GenerateJsonSerializableAttribute(
                type,
                typeInfoPropertyName));
        }

        return string.Join("\n", attributes);
    }

    private static string GenerateJsonSerializableAttribute(
        string type,
        string? typeInfoPropertyName)
    {
        return typeInfoPropertyName is null
            ? $"    [global::System.Text.Json.Serialization.JsonSerializable(typeof({type}))]"
            : $"    [global::System.Text.Json.Serialization.JsonSerializable(typeof({type}), TypeInfoPropertyName = \"{typeInfoPropertyName}\")]";
    }

    private static Dictionary<string, string> BuildExplicitTypeInfoPropertyNames(
        string[] types,
        HashSet<string> implicitlyDiscoveredTypes)
    {
        var explicitNames = new Dictionary<string, string>(StringComparer.Ordinal);
        var usedNames = new HashSet<string>(StringComparer.Ordinal);

        // Phase 1: Handle collisions among explicitly registered types
        foreach (var group in types.GroupBy(GetImplicitTypeInfoPropertyName).Where(group => group.Count() > 1))
        {
            var defaultType = group.FirstOrDefault(ShouldKeepDefaultTypeInfoPropertyName) ?? group.First();

            foreach (var type in group)
            {
                if (type == defaultType)
                {
                    continue;
                }

                var baseName = $"{GetImplicitTypeInfoPropertyName(type)}_{SanitizeTypeInfoPropertyName(type)}";
                var name = baseName;
                var suffix = 2;

                while (!usedNames.Add(name))
                {
                    name = $"{baseName}_{suffix++}";
                }

                explicitNames[type] = name;
            }
        }

        // Phase 2: Handle collisions between explicit attributes and implicit STJ discovery.
        // Value types with nullable variants in JsonSerializerContextTypes cause STJ to
        // discover the inner non-nullable type implicitly. If the same type is also
        // explicitly registered via [JsonSerializable], SYSLIB1031 fires.
        foreach (var type in types)
        {
            if (explicitNames.ContainsKey(type))
            {
                continue;
            }

            if (!implicitlyDiscoveredTypes.Contains(type))
            {
                continue;
            }

            var implicitName = GetImplicitTypeInfoPropertyName(type);
            var baseName = $"{implicitName}2";
            var name = baseName;
            var suffix = 3;

            while (!usedNames.Add(name))
            {
                name = $"{implicitName}{suffix++}";
            }

            explicitNames[type] = name;
        }

        return explicitNames;
    }

    private static string GetImplicitTypeInfoPropertyName(string type)
    {
        if (type.StartsWith("global::", StringComparison.Ordinal))
        {
            type = type.Substring("global::".Length);
        }

        if (CSharpAliasTypeInfoPropertyNames.TryGetValue(type, out var aliasName))
        {
            return aliasName;
        }

        if (type.EndsWith("[]", StringComparison.Ordinal))
        {
            return $"{GetImplicitTypeInfoPropertyName(type.Substring(0, type.Length - 2))}Array";
        }

        if (type.EndsWith("?", StringComparison.Ordinal))
        {
            return GetImplicitTypeInfoPropertyName(type.Substring(0, type.Length - 1));
        }

        var genericStart = type.IndexOf('<');
        if (genericStart >= 0 && type.EndsWith(">", StringComparison.Ordinal))
        {
            var typeName = GetSimpleTypeName(type.Substring(0, genericStart));
            var genericArguments = type.Substring(genericStart + 1, type.Length - genericStart - 2);
            return typeName + string.Concat(SplitGenericArguments(genericArguments).Select(GetImplicitTypeInfoPropertyName));
        }

        return GetSimpleTypeName(type);
    }

    private static IEnumerable<string> SplitGenericArguments(string genericArguments)
    {
        var start = 0;
        var depth = 0;

        for (var index = 0; index < genericArguments.Length; index++)
        {
            switch (genericArguments[index])
            {
                case '<':
                    depth++;
                    break;
                case '>':
                    depth--;
                    break;
                case ',' when depth == 0:
                    yield return genericArguments.Substring(start, index - start).Trim();
                    start = index + 1;
                    break;
            }
        }

        yield return genericArguments.Substring(start).Trim();
    }

    private static string GetSimpleTypeName(string type)
    {
        var start = Math.Max(type.LastIndexOf('.'), type.LastIndexOf(':')) + 1;
        var simpleName = type.Substring(start);
        var arity = simpleName.IndexOf('`');
        return arity >= 0 ? simpleName.Substring(0, arity) : simpleName;
    }

    private static string SanitizeTypeInfoPropertyName(string type)
    {
        if (type.StartsWith("global::", StringComparison.Ordinal))
        {
            type = type.Substring("global::".Length);
        }

        var buffer = new char[type.Length];
        var count = 0;
        var lastWasUnderscore = false;

        foreach (var character in type)
        {
            if (char.IsLetterOrDigit(character))
            {
                buffer[count++] = character;
                lastWasUnderscore = false;
                continue;
            }

            if (lastWasUnderscore)
            {
                continue;
            }

            buffer[count++] = '_';
            lastWasUnderscore = true;
        }

        var sanitized = new string(buffer, 0, count).Trim('_');
        if (sanitized.Length == 0)
        {
            sanitized = "Type";
        }

        return char.IsDigit(sanitized[0]) ? $"_{sanitized}" : sanitized;
    }

    private static bool ShouldKeepDefaultTypeInfoPropertyName(string type)
    {
        if (type.StartsWith("global::", StringComparison.Ordinal))
        {
            return type.StartsWith("global::System.", StringComparison.Ordinal);
        }

        return CSharpAliasTypeInfoPropertyNames.ContainsKey(type);
    }

    private static readonly Dictionary<string, string> CSharpAliasTypeInfoPropertyNames = new(StringComparer.Ordinal)
    {
        ["bool"] = "Boolean",
        ["byte"] = "Byte",
        ["char"] = "Char",
        ["decimal"] = "Decimal",
        ["double"] = "Double",
        ["float"] = "Single",
        ["int"] = "Int32",
        ["long"] = "Int64",
        ["nint"] = "IntPtr",
        ["nuint"] = "UIntPtr",
        ["object"] = "Object",
        ["sbyte"] = "SByte",
        ["short"] = "Int16",
        ["string"] = "String",
        ["uint"] = "UInt32",
        ["ulong"] = "UInt64",
        ["ushort"] = "UInt16",
        ["void"] = "Void",
    };

    /// <summary>
    /// Returns concrete List&lt;T&gt; counterparts for IList&lt;T&gt; types,
    /// excluding any that already exist in <paramref name="distinctTypes"/>.
    /// </summary>
    public static string[] GetConcreteListTypes(string[] distinctTypes)
    {
        var distinctTypesSet = new HashSet<string>(distinctTypes);
        return distinctTypes
            .Where(x => x.Contains("System.Collections.Generic.IList<"))
            .Select(x => x.Replace(
                "System.Collections.Generic.IList<",
                "System.Collections.Generic.List<"))
            .Distinct()
            .Where(x => !distinctTypesSet.Contains(x))
            .ToArray();
    }
}
