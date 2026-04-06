using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
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
        // Only value types cause this — reference type nullability (string?, byte[]?) doesn't
        // create Nullable<T> wrappers and thus doesn't trigger implicit discovery.
        var implicitlyDiscoveredTypes = new HashSet<string>(
            types
                .Where(x => x.IsValueType &&
                            x.CSharpTypeWithNullability != x.CSharpTypeWithoutNullability &&
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
        var usedNames = new HashSet<string>(
            types.Select(GetImplicitTypeInfoPropertyName),
            StringComparer.Ordinal);

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
                explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                    usedNames,
                    baseName,
                    type);
            }
        }

        // Phase 1b: STJ derives TypeInfo property names from full generic type signatures.
        // Very large unions can push those implicit names over the compiler's metadata limits
        // even when there is no collision, so force a shorter explicit name in that case.
        foreach (var type in types)
        {
            if (explicitNames.ContainsKey(type))
            {
                continue;
            }

            var implicitName = GetImplicitTypeInfoPropertyName(type);
            if (implicitName.Length <= MaxGeneratedTypeInfoNameLength)
            {
                continue;
            }

            explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                usedNames,
                implicitName,
                type);
        }

        // Phase 2: Handle collisions between explicit attributes and implicit STJ discovery.
        // Value types with nullable variants in JsonSerializerContextTypes cause STJ to
        // discover the inner non-nullable type implicitly. If the same type is also
        // explicitly registered via [JsonSerializable], SYSLIB1031 fires.
        // Skip built-in types (System.*, C# aliases) — STJ handles those natively.
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

            if (ShouldKeepDefaultTypeInfoPropertyName(type))
            {
                continue;
            }

            var implicitName = GetImplicitTypeInfoPropertyName(type);
            var baseName = $"{implicitName}2";
            explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                usedNames,
                baseName,
                type);
        }

        // Phase 3: Handle collisions between explicit types and STJ's implicit nullable naming.
        // When STJ discovers Nullable<T> from JsonSerializerContextTypes, it names the TypeInfo
        // "Nullable{TypeName}". If another explicit type has that same implicit name, it collides.
        // Example: LLMModel? → STJ names it "NullableLLMModel", colliding with schema type NullableLLMModel.
        var implicitNullableNames = new HashSet<string>(
            implicitlyDiscoveredTypes
                .Where(type => !ShouldKeepDefaultTypeInfoPropertyName(type))
                .Select(type => $"Nullable{GetImplicitTypeInfoPropertyName(type)}"),
            StringComparer.Ordinal);

        foreach (var type in types)
        {
            if (explicitNames.ContainsKey(type))
            {
                continue;
            }

            var implicitName = GetImplicitTypeInfoPropertyName(type);
            if (!implicitNullableNames.Contains(implicitName))
            {
                continue;
            }

            var baseName = $"{implicitName}2";
            explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                usedNames,
                baseName,
                type);
        }

        return explicitNames;
    }

    private const int MaxExplicitTypeInfoPropertyNameLength = 120;
    private const int MaxGeneratedTypeInfoNameLength = 120;

    public static bool HasOversizedGeneratedJsonSerializerContextTypeNames(
        EquatableArray<TypeData> types)
    {
        var distinctTypeNames = types
            .Select(static x => x.CSharpTypeWithoutNullability)
            .Where(static x => !string.IsNullOrWhiteSpace(x))
            .Distinct(StringComparer.Ordinal)
            .ToArray();

        if (distinctTypeNames.Any(static x => GetImplicitTypeInfoPropertyName(x).Length > MaxGeneratedTypeInfoNameLength))
        {
            return true;
        }

        if (types.Any(static x =>
                x.IsValueType &&
                x.CSharpTypeWithNullability != x.CSharpTypeWithoutNullability &&
                $"Nullable{GetImplicitTypeInfoPropertyName(x.CSharpTypeWithoutNullability)}".Length > MaxGeneratedTypeInfoNameLength))
        {
            return true;
        }

        var concreteListTypes = GetConcreteListTypes(
            types
                .Select(static x => x.CSharpTypeWithNullability)
                .Where(static x => !string.IsNullOrWhiteSpace(x))
                .Distinct(StringComparer.Ordinal)
                .ToArray());

        return concreteListTypes.Any(static x => GetImplicitTypeInfoPropertyName(x).Length > MaxGeneratedTypeInfoNameLength);
    }

    private static bool ShouldIncludeInJsonSerializerContextTypes(string type)
    {
        var implicitName = GetImplicitTypeInfoPropertyName(type);
        if (implicitName.Length > MaxGeneratedTypeInfoNameLength)
        {
            return false;
        }

        return !type.EndsWith("?", StringComparison.Ordinal) ||
               $"Nullable{implicitName}".Length <= MaxGeneratedTypeInfoNameLength;
    }

    private static string ReserveExplicitTypeInfoPropertyName(
        HashSet<string> usedNames,
        string baseName,
        string type)
    {
        for (var suffix = 0; ; suffix++)
        {
            var candidateSeed = suffix == 0
                ? baseName
                : $"{baseName}_{suffix + 2}";
            var candidate = NormalizeExplicitTypeInfoPropertyName(candidateSeed, type);

            if (usedNames.Add(candidate))
            {
                return candidate;
            }
        }
    }

    private static string NormalizeExplicitTypeInfoPropertyName(string candidate, string type)
    {
        if (candidate.Length <= MaxExplicitTypeInfoPropertyNameLength)
        {
            return candidate;
        }

        var prefix = SanitizeTypeInfoPropertyName(GetSimpleTypeName(type));
        var hash = ComputeStableTypeInfoPropertyNameHash(candidate);
        var maxPrefixLength = MaxExplicitTypeInfoPropertyNameLength - hash.Length - 1;

        if (maxPrefixLength <= 0)
        {
            return hash;
        }

        if (prefix.Length > maxPrefixLength)
        {
            prefix = prefix.Substring(0, maxPrefixLength);
        }

        if (prefix.Length == 0)
        {
            prefix = "Type";
            if (prefix.Length > maxPrefixLength)
            {
                prefix = prefix.Substring(0, maxPrefixLength);
            }
        }

        return $"{prefix}_{hash}";
    }

    private static string ComputeStableTypeInfoPropertyNameHash(string value)
    {
        var bytes = Encoding.UTF8.GetBytes(value);
#if NET10_0_OR_GREATER
        var hash = SHA256.HashData(bytes);
#else
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(bytes);
#endif
        var builder = new StringBuilder(capacity: 16);

        for (var index = 0; index < 8; index++)
        {
            builder.Append(hash[index].ToString("x2", CultureInfo.InvariantCulture));
        }

        return builder.ToString();
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
        if (type.EndsWith("[]", StringComparison.Ordinal))
        {
            return ShouldKeepDefaultTypeInfoPropertyName(type.Substring(0, type.Length - 2));
        }

        if (type.EndsWith("?", StringComparison.Ordinal))
        {
            return ShouldKeepDefaultTypeInfoPropertyName(type.Substring(0, type.Length - 1));
        }

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
