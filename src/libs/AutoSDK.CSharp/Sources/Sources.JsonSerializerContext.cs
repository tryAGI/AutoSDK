using AutoSDK.Extensions;
using AutoSDK.Helpers;
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
        return GenerateJsonSerializerContext(
            client,
            types,
            new JsonSerializerContextGenerationState(),
            cancellationToken);
    }

    internal static string GenerateJsonSerializerContext(
        Client client,
        EquatableArray<TypeData> types,
        JsonSerializerContextGenerationState generationState,
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
        var typeInfoNames = generationState.TypeInfoNames;
        var nullableValueTypes = generationState.GetNullableValueTypes(types);
        var typeComponents = generationState.GetJsonSerializableTypeComponents(types);

        var serializableTypeSet = types.IsEmpty
            ? default
            : BuildJsonSerializableTypeSet(
                client,
                expandContextTypes: false,
                typeComponents,
                nullableValueTypes);
        var useChunkedContext = serializableTypeSet.SerializableTypes is { Length: > MaxJsonSerializableAttributesPerContext };
        if (useChunkedContext)
        {
            serializableTypeSet = BuildJsonSerializableTypeSet(
                client,
                expandContextTypes: true,
                typeComponents,
                nullableValueTypes);
        }

        var jsonSerializableAttributes = types.IsEmpty
            ? Array.Empty<JsonSerializableAttributeRegistration>()
            : GenerateJsonSerializableAttributeRegistrations(
                client,
                types,
                serializableTypeSet,
                typeInfoNames,
                nullableValueTypes);

        if (jsonSerializableAttributes.Length == 0)
        {
            return GenerateEmptyJsonSerializerContext(
                client,
                contextClassName);
        }

        if (useChunkedContext)
        {
            // JsonSerializerContextTypes is an aggregate carrier whose properties reference
            // every known type. Registering it in a chunk makes STJ recursively regenerate the
            // complete metadata graph in that one context, defeating the split and potentially
            // pushing its compiler-generated <>c type past the CLR method limit.
            return GenerateChunkedJsonSerializerContext(
                client,
                contextClassName,
                jsonSerializableAttributes);
        }

        using var builder = new PooledStringBuilder(
            1024 + jsonSerializableAttributes.Sum(EstimateJsonSerializableAttributeLength));
        builder.Append($@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {client.Settings.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
");
        AppendJsonSourceGenerationOptionsAttribute(builder, client);
        builder.Append('\n');
        AppendJsonSerializableAttributes(builder, jsonSerializableAttributes);
        builder.Append($@"
    public sealed partial class {contextClassName} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
}}");
        return builder.ToString();
    }

    private const int MaxJsonSerializableAttributesPerContext = 500;

    private static string GenerateEmptyJsonSerializerContext(
        Client client,
        string contextClassName)
    {
        using var builder = new PooledStringBuilder(
            1024 + client.Converters.Sum(static converter => converter.Length + 64));
        builder.Append($@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {client.Settings.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
");
        AppendJsonSourceGenerationOptionsAttribute(builder, client);
        builder.Append($@"
    public sealed partial class {contextClassName} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static {contextClassName} Default {{ get; }} = new(DefaultOptions);

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {contextClassName}()
            : this(DefaultOptions)
        {{
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {contextClassName}(global::System.Text.Json.JsonSerializerOptions? options)
            : base(options)
        {{
        }}

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {{
            return null;
        }}

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {{
            var options = new global::System.Text.Json.JsonSerializerOptions
            {{
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            }};");
        foreach (var converter in client.Converters)
        {
            builder.Append($@"
            options.Converters.Add(new {converter}());");
        }

        builder.Append($@"
            return options;
        }}
    }}
}}");
        return builder.ToString();
    }

    private static string GenerateChunkedJsonSerializerContext(
        Client client,
        string contextClassName,
        JsonSerializableAttributeRegistration[] jsonSerializableAttributes)
    {
        var chunks = SplitJsonSerializableAttributes(jsonSerializableAttributes)
            .ToArray();
        var chunkClassNames = chunks
            .Select((_, index) => $"{contextClassName}Chunk{index}")
            .ToArray();
        var lazyConverterRegistrations = GetLazyEnumConverterRegistrations(client.Converters);
        var lazyConverterTypes = new HashSet<string>(
            lazyConverterRegistrations.Select(static registration => registration.ConverterType),
            StringComparer.Ordinal);
        var eagerConverters = client.Converters
            .Where(converter => !lazyConverterTypes.Contains(converter))
            .ToArray();

        var initialCapacity = 4096;
        foreach (var chunk in chunks)
        {
            foreach (var registration in chunk)
            {
                initialCapacity = checked(
                    initialCapacity + EstimateJsonSerializableAttributeLength(registration));
            }
        }
        foreach (var registration in lazyConverterRegistrations)
        {
            initialCapacity = checked(
                initialCapacity +
                384 +
                (registration.TargetType.Length * 2) +
                registration.ConverterType.Length);
        }
        foreach (var converter in eagerConverters)
        {
            initialCapacity = checked(initialCapacity + converter.Length + 64);
        }
        foreach (var chunkClassName in chunkClassNames)
        {
            initialCapacity = checked(initialCapacity + (chunkClassName.Length * 2) + 256);
        }

        using var builder = new PooledStringBuilder(initialCapacity);
        builder.Append($@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {client.Settings.Namespace}
{{");
        for (var index = 0; index < chunks.Length; index++)
        {
            builder.Append($@"
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
");
            AppendJsonSourceGenerationOptionsAttribute(builder, client, includeConverters: false);
            builder.Append('\n');
            AppendJsonSerializableAttributes(builder, chunks[index]);
            builder.Append($@"
    internal sealed partial class {chunkClassNames[index]} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
");
        }

        builder.Append($@"    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class {contextClassName} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static {contextClassName} Default {{ get; }} = new(DefaultOptions);

        private {contextClassName}(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {{
        }}

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {{
            return Resolver.GetTypeInfo(type, Options);
        }}

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {{
            var options = new global::System.Text.Json.JsonSerializerOptions
            {{
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            }};");
        foreach (var converter in eagerConverters)
        {
            builder.Append($@"
            options.Converters.Add(new {converter}());");
        }
        if (lazyConverterRegistrations.Length > 0)
        {
            builder.Append(@"

            options.Converters.Add(new LazyEnumJsonConverterFactory());");
        }

        builder.Append(@"

            return options;
        }");
        if (lazyConverterRegistrations.Length > 0)
        {
            builder.Append(@"


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return");
            for (var index = 0; index < lazyConverterRegistrations.Length; index++)
            {
                var registration = lazyConverterRegistrations[index];
                builder.Append(index == 0 ? "\n" : "\n\n");
                builder.Append($@"                    {(index == 0 ? "" : "|| ")}typeToConvert == typeof({registration.TargetType})");
            }
            builder.Append(@";
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {");
            for (var index = 0; index < lazyConverterRegistrations.Length; index++)
            {
                var registration = lazyConverterRegistrations[index];
                builder.Append(index == 0 ? "\n" : "\n\n");
                builder.Append($@"                if (typeToConvert == typeof({registration.TargetType}))
                {{
                    return new {registration.ConverterType}();
                }}");
            }
            builder.Append(@"
                throw new global::System.NotSupportedException($""No generated enum converter is registered for '{typeToConvert}'."");
            }
        }");
        }

        builder.Append($@"

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {{
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[{chunkClassNames.Length}];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {{
                for (var index = 0; index < _resolvers.Length; index++)
                {{
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {{
                        return typeInfo;
                    }}
                }}

                return null;
            }}

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {{
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {{
                    return resolver;
                }}

                lock (_gate)
                {{
                    return _resolvers[index] ??= CreateResolver(index);
                }}
            }}

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {{
                return index switch
                {{
{chunkClassNames.Select((className, index) => $@"
                    {index} => new {className}(new global::System.Text.Json.JsonSerializerOptions()),
").Inject()}
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                }};
            }}
        }}
    }}
}}");
        return builder.ToString();
    }

    private readonly struct LazyConverterRegistration
    {
        public LazyConverterRegistration(
            string targetType,
            string converterType)
        {
            TargetType = targetType;
            ConverterType = converterType;
        }

        public string TargetType { get; }

        public string ConverterType { get; }
    }

    private static LazyConverterRegistration[] GetLazyEnumConverterRegistrations(
        EquatableArray<string> converters)
    {
        const string converterNamespaceMarker = ".JsonConverters.";
        const string converterSuffix = "JsonConverter";
        const string nullableConverterSuffix = "NullableJsonConverter";

        var converterSet = new HashSet<string>(converters, StringComparer.Ordinal);
        var registrations = new List<LazyConverterRegistration>();

        foreach (var nullableConverter in converters.Where(static converter =>
                     converter.EndsWith(nullableConverterSuffix, StringComparison.Ordinal)))
        {
            var converterNamespaceIndex = nullableConverter.LastIndexOf(
                converterNamespaceMarker,
                StringComparison.Ordinal);
            if (converterNamespaceIndex < 0)
            {
                continue;
            }

            var typeNameStart = converterNamespaceIndex + converterNamespaceMarker.Length;
            var typeNameLength = nullableConverter.Length - typeNameStart - nullableConverterSuffix.Length;
            if (typeNameLength <= 0)
            {
                continue;
            }

            var typeName = nullableConverter.Substring(typeNameStart, typeNameLength);
            var converterNamespacePrefix = nullableConverter.Substring(0, converterNamespaceIndex);
            var nonNullableConverter = $"{converterNamespacePrefix}{converterNamespaceMarker}{typeName}{converterSuffix}";
            if (!converterSet.Contains(nonNullableConverter))
            {
                continue;
            }

            var targetType = $"{converterNamespacePrefix}.{typeName}";
            registrations.Add(new LazyConverterRegistration(targetType, nonNullableConverter));
            registrations.Add(new LazyConverterRegistration($"{targetType}?", nullableConverter));
        }

        return registrations.ToArray();
    }

    private static void AppendJsonSourceGenerationOptionsAttribute(
        PooledStringBuilder builder,
        Client client,
        bool includeConverters = true)
    {
        IEnumerable<string> converters = includeConverters
            ? client.Converters
            : Array.Empty<string>();

        builder.Append(@"    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {");
        var firstConverter = true;
        foreach (var converter in converters)
        {
            builder.Append('\n');
            if (!firstConverter)
            {
                builder.Append('\n');
            }
            builder.Append("            typeof(");
            builder.Append(converter);
            builder.Append("),");
            firstConverter = false;
        }
        builder.Append(@"
        })]");
    }

    private readonly struct JsonSerializableAttributeRegistration
    {
        public JsonSerializableAttributeRegistration(
            string type,
            string? typeInfoPropertyName,
            string? generationMode,
            bool isGuard)
        {
            Type = type;
            TypeInfoPropertyName = typeInfoPropertyName;
            GenerationMode = generationMode;
            IsGuard = isGuard;
        }

        public string Type { get; }

        public string? TypeInfoPropertyName { get; }

        public string? GenerationMode { get; }

        public bool IsGuard { get; }
    }

    private static int EstimateJsonSerializableAttributeLength(
        JsonSerializableAttributeRegistration registration)
    {
        return 96 +
               registration.Type.Length +
               (registration.TypeInfoPropertyName?.Length ?? 0) +
               (registration.GenerationMode?.Length ?? 0);
    }

    private static void AppendJsonSerializableAttributes(
        PooledStringBuilder builder,
        JsonSerializableAttributeRegistration[] registrations)
    {
        for (var index = 0; index < registrations.Length; index++)
        {
            if (index > 0)
            {
                builder.Append('\n');
            }

            var registration = registrations[index];
            builder.Append("    [global::System.Text.Json.Serialization.JsonSerializable(typeof(");
            builder.Append(registration.Type);
            builder.Append(')');
            if (registration.TypeInfoPropertyName is not null)
            {
                builder.Append(", TypeInfoPropertyName = \"");
                builder.Append(registration.TypeInfoPropertyName);
                builder.Append('"');
            }

            if (registration.GenerationMode is not null)
            {
                builder.Append(", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.");
                builder.Append(registration.GenerationMode);
            }

            builder.Append(")]");
        }
    }

    private static IEnumerable<JsonSerializableAttributeRegistration[]> SplitJsonSerializableAttributes(
        JsonSerializableAttributeRegistration[] jsonSerializableAttributes)
    {
        var guardAttributeCount = jsonSerializableAttributes.Count(static registration => registration.IsGuard);

        if (guardAttributeCount >= MaxJsonSerializableAttributesPerContext)
        {
            foreach (var chunk in ChunkJsonSerializableAttributes(jsonSerializableAttributes))
            {
                yield return chunk;
            }

            yield break;
        }

        var guardAttributes = new JsonSerializableAttributeRegistration[guardAttributeCount];
        var regularAttributes = new JsonSerializableAttributeRegistration[
            jsonSerializableAttributes.Length - guardAttributeCount];
        var guardIndex = 0;
        var regularIndex = 0;
        foreach (var registration in jsonSerializableAttributes)
        {
            if (registration.IsGuard)
            {
                guardAttributes[guardIndex++] = registration;
            }
            else
            {
                regularAttributes[regularIndex++] = registration;
            }
        }

        var regularAttributesPerContext = Math.Max(
            1,
            MaxJsonSerializableAttributesPerContext - guardAttributeCount);

        for (var start = 0; start < regularAttributes.Length; start += regularAttributesPerContext)
        {
            var count = Math.Min(regularAttributesPerContext, regularAttributes.Length - start);
            var chunk = new JsonSerializableAttributeRegistration[guardAttributeCount + count];
            Array.Copy(guardAttributes, chunk, guardAttributeCount);
            Array.Copy(regularAttributes, start, chunk, guardAttributeCount, count);
            yield return chunk;
        }

        if (regularAttributes.Length == 0 &&
            guardAttributeCount > 0)
        {
            yield return guardAttributes;
        }
    }

    private static IEnumerable<JsonSerializableAttributeRegistration[]> ChunkJsonSerializableAttributes(
        JsonSerializableAttributeRegistration[] jsonSerializableAttributes)
    {
        for (var start = 0; start < jsonSerializableAttributes.Length; start += MaxJsonSerializableAttributesPerContext)
        {
            var count = Math.Min(MaxJsonSerializableAttributesPerContext, jsonSerializableAttributes.Length - start);
            var chunk = new JsonSerializableAttributeRegistration[count];
            Array.Copy(jsonSerializableAttributes, start, chunk, 0, count);
            yield return chunk;
        }
    }

    private static (
        string[] SerializableTypes,
        string[] ExplicitNullableValueTypes,
        string[] ContextTypes) BuildJsonSerializableTypeSet(
        Client client,
        bool expandContextTypes,
        JsonSerializableTypeComponents typeComponents,
        string[] nullableValueTypes)
    {
        var contextNullableValueTypes = expandContextTypes
            ? nullableValueTypes
            : typeComponents.ExplicitNullableValueTypes;
        var contextTypes = expandContextTypes
            ? new[]
            {
                "global::System.Collections.Generic.Dictionary<string, string>",
                "global::System.Collections.Generic.Dictionary<string, object>",
                "global::System.Collections.Generic.List<object>",
                "global::System.Text.Json.JsonElement?",
            }
            : new[]
            {
                $"global::{client.Settings.Namespace}.JsonSerializerContextTypes",
                "global::System.Collections.Generic.List<object>",
            };
        var serializableTypes = contextTypes
            .Concat(typeComponents.DistinctTypes)
            .Concat(contextNullableValueTypes)
            .Concat(typeComponents.ConcreteListTypes)
            .Distinct(StringComparer.Ordinal)
            .ToArray();

        return (serializableTypes, typeComponents.ExplicitNullableValueTypes, contextTypes);
    }

    private static JsonSerializableAttributeRegistration[] GenerateJsonSerializableAttributeRegistrations(
        Client client,
        EquatableArray<TypeData> types,
        (string[] SerializableTypes, string[] ExplicitNullableValueTypes, string[] ContextTypes) typeSet,
        JsonTypeInfoNameCache typeInfoNames,
        string[] nullableValueTypes)
    {
        var serializableTypes = typeSet.SerializableTypes;
        var explicitNullableValueTypes = typeSet.ExplicitNullableValueTypes;
        var contextTypes = typeSet.ContextTypes;

        // Value types with nullable variants in JsonSerializerContextTypes will be
        // implicitly discovered by STJ through the nullable property (T? → Nullable<T> → T).
        // This causes SYSLIB1031 when the same type is also explicitly registered.
        // Only value types cause this — reference type nullability (string?, byte[]?) doesn't
        // create Nullable<T> wrappers and thus doesn't trigger implicit discovery.
        var implicitlyDiscoveredTypes = CreateStringSet(nullableValueTypes.Length + contextTypes.Length);
        foreach (var type in nullableValueTypes)
        {
            implicitlyDiscoveredTypes.Add(type.Substring(0, type.Length - 1));
        }
        foreach (var type in contextTypes)
        {
            if (string.Equals(
                    type,
                    "global::System.Text.Json.JsonElement?",
                    StringComparison.Ordinal))
            {
                implicitlyDiscoveredTypes.Add(type.Substring(0, type.Length - 1));
            }
        }

        var explicitTypeInfoPropertyNames = BuildExplicitTypeInfoPropertyNames(
            serializableTypes,
            implicitlyDiscoveredTypes,
            typeInfoNames);
        const string objectListType = "global::System.Collections.Generic.List<object>";
        if (serializableTypes.Contains(objectListType, StringComparer.Ordinal) &&
            !explicitTypeInfoPropertyNames.ContainsKey(objectListType))
        {
            var usedTypeInfoPropertyNames = new HashSet<string>(
                serializableTypes.Select(typeInfoNames.GetGenerated)
                    .Concat(explicitTypeInfoPropertyNames.Values),
                StringComparer.Ordinal);
            explicitTypeInfoPropertyNames[objectListType] = ReserveExplicitTypeInfoPropertyName(
                usedTypeInfoPropertyNames,
                "SystemCollectionsGeneric_ObjectList",
                objectListType);
        }
        var guardTypes = GetJsonSerializableGuardTypes(
            serializableTypes,
            explicitNullableValueTypes,
            typeInfoNames);
        var generationModes = BuildJsonSourceGenerationModes(
            client,
            types,
            serializableTypes,
            alwaysDefaultTypes: contextTypes);

        var registrations = new JsonSerializableAttributeRegistration[serializableTypes.Length];

        for (var index = 0; index < serializableTypes.Length; index++)
        {
            var type = serializableTypes[index];
            explicitTypeInfoPropertyNames.TryGetValue(type, out var typeInfoPropertyName);
            string? generationMode = null;
            generationModes?.TryGetValue(type, out generationMode);
            registrations[index] = new JsonSerializableAttributeRegistration(
                type,
                typeInfoPropertyName,
                generationMode,
                guardTypes.Contains(type));
        }

        return registrations;
    }

    /// <summary>
    /// Maps every registered type to the narrowest <c>JsonSourceGenerationMode</c> that is safe
    /// for the direction(s) it is used in:
    /// <list type="bullet">
    /// <item>request-only types drop their property metadata (<c>Serialization</c>),</item>
    /// <item>response-only types drop their fast-path writer (<c>Metadata</c>),</item>
    /// <item>types used in both directions, or not reachable from any operation, keep <c>Default</c>.</item>
    /// </list>
    /// Returns null when direction-aware modes are disabled; types absent from the result keep
    /// the context default.
    /// </summary>
    private static Dictionary<string, string>? BuildJsonSourceGenerationModes(
        Client client,
        EquatableArray<TypeData> types,
        string[] serializableTypes,
        string[] alwaysDefaultTypes)
    {
        if (!client.Settings.DirectionAwareJsonGenerationMode ||
            !client.Settings.UsesSystemTextJson())
        {
            return null;
        }

        // System.Text.Json disables source-generated fast-path serialization for every type in a
        // context whose options carry custom converters, and a `Serialization`-only registration
        // has no property metadata to fall back on. So `Serialization` is only usable when the
        // SDK registers no converters, and when it does register them the generated fast-path
        // writers are unreachable code that `Metadata` drops.
        var fastPathAvailable = client.Converters.Length == 0;

        var directions = new Dictionary<string, JsonSerializationDirection>(StringComparer.Ordinal);
        var generatedJsonHelperTypes = new HashSet<string>(StringComparer.Ordinal);
        foreach (var type in types)
        {
            var name = type.CSharpTypeWithoutNullability;
            if (string.IsNullOrWhiteSpace(name))
            {
                continue;
            }

            directions[name] = directions.TryGetValue(name, out var existing)
                ? existing | type.JsonSerializationDirection
                : type.JsonSerializationDirection;

            if (type.UsesGeneratedJsonHelpers)
            {
                generatedJsonHelperTypes.Add(name);
            }
        }

        var alwaysDefault = new HashSet<string>(alwaysDefaultTypes, StringComparer.Ordinal);
        var modes = new Dictionary<string, string>(StringComparer.Ordinal);

        foreach (var type in serializableTypes)
        {
            if (alwaysDefault.Contains(type))
            {
                continue;
            }

            var lookupType = ResolveDirectionLookupType(NormalizeRuntimeTypeName(type), directions);
            if (lookupType is null)
            {
                continue;
            }

            var mode = directions[lookupType] switch
            {
                // Response-only types are never written, so the fast-path writer is dead weight.
                JsonSerializationDirection.Response => "Metadata",
                // The generated FromJson helpers need property metadata, so types that expose
                // them can only keep their fast path through the default mode.
                JsonSerializationDirection.Request => fastPathAvailable && !generatedJsonHelperTypes.Contains(lookupType)
                    ? "Serialization"
                    // Without a reachable fast path the generated writer is dead weight too.
                    : fastPathAvailable ? null : "Metadata",
                _ => null,
            };

            if (mode is not null)
            {
                modes[type] = mode;
            }
        }

        return modes;
    }

    /// <summary>
    /// Finds the key under which <paramref name="type"/> was classified, mapping the concrete
    /// List&lt;T&gt; registrations back onto the IList&lt;T&gt; types they were derived from.
    /// </summary>
    private static string? ResolveDirectionLookupType(
        string type,
        Dictionary<string, JsonSerializationDirection> directions)
    {
        if (directions.ContainsKey(type))
        {
            return type;
        }

        var interfaceType = type.Replace(
            "System.Collections.Generic.List<",
            "System.Collections.Generic.IList<");

        return interfaceType != type && directions.ContainsKey(interfaceType)
            ? interfaceType
            : null;
    }

    private static Dictionary<string, string> BuildExplicitTypeInfoPropertyNames(
        string[] types,
        HashSet<string> implicitlyDiscoveredTypes,
        JsonTypeInfoNameCache typeInfoNames)
    {
        var explicitNames = new Dictionary<string, string>(StringComparer.Ordinal);
        var usedNames = CreateStringSet(types.Length);
        var firstTypeByGeneratedName = new Dictionary<string, string>(types.Length, StringComparer.Ordinal);
        var collidingTypesByGeneratedName = new Dictionary<string, List<string>>(StringComparer.Ordinal);
        var generatedNameOrder = new List<string>();
        foreach (var type in types)
        {
            var generatedName = typeInfoNames.GetGenerated(type);
            usedNames.Add(generatedName);
            if (!firstTypeByGeneratedName.TryGetValue(generatedName, out var firstType))
            {
                firstTypeByGeneratedName.Add(generatedName, type);
                generatedNameOrder.Add(generatedName);
                continue;
            }

            if (!collidingTypesByGeneratedName.TryGetValue(generatedName, out var collidingTypes))
            {
                collidingTypes = [firstType];
                collidingTypesByGeneratedName.Add(generatedName, collidingTypes);
            }
            collidingTypes.Add(type);
        }

        // Phase 1: Handle collisions among explicitly registered types
        foreach (var generatedName in generatedNameOrder)
        {
            if (!collidingTypesByGeneratedName.TryGetValue(generatedName, out var collidingTypes))
            {
                continue;
            }

            var defaultType = collidingTypes.FirstOrDefault(static type =>
                ShouldKeepDefaultTypeInfoPropertyName(type) &&
                !type.Contains("<", StringComparison.Ordinal));

            foreach (var type in collidingTypes)
            {
                if (defaultType is not null &&
                    type == defaultType)
                {
                    continue;
                }

                var baseName = $"{typeInfoNames.GetGenerated(type)}_{SanitizeTypeInfoPropertyName(type)}";
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

            var implicitName = typeInfoNames.GetGenerated(type);
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

            var implicitName = typeInfoNames.GetImplicit(type);
            var baseName = $"{implicitName}2";
            explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                usedNames,
                baseName,
                type);
        }

        // Phase 2b: Nullable value types registered through an aggregate context cause STJ to
        // discover both Nullable<T> and T. A generated model can share T's simple name even when
        // its runtime type is in a different namespace (for example Advantage.JsonElement versus
        // System.Text.Json.JsonElement), so disambiguate that explicit registration too.
        var firstImplicitRuntimeTypeByName = new Dictionary<string, string>(
            implicitlyDiscoveredTypes.Count,
            StringComparer.Ordinal);
        var collidingImplicitRuntimeTypesByName = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);
        foreach (var type in implicitlyDiscoveredTypes)
        {
            var generatedName = typeInfoNames.GetGenerated(type);
            var runtimeType = NormalizeRuntimeTypeName(type);
            if (!firstImplicitRuntimeTypeByName.TryGetValue(generatedName, out var firstRuntimeType))
            {
                firstImplicitRuntimeTypeByName.Add(generatedName, runtimeType);
                continue;
            }

            if (string.Equals(firstRuntimeType, runtimeType, StringComparison.Ordinal))
            {
                continue;
            }

            if (!collidingImplicitRuntimeTypesByName.TryGetValue(generatedName, out var collidingRuntimeTypes))
            {
                collidingRuntimeTypes = new HashSet<string>(StringComparer.Ordinal)
                {
                    firstRuntimeType,
                };
                collidingImplicitRuntimeTypesByName.Add(generatedName, collidingRuntimeTypes);
            }
            collidingRuntimeTypes.Add(runtimeType);
        }

        foreach (var type in types)
        {
            if (explicitNames.ContainsKey(type))
            {
                continue;
            }

            var implicitName = typeInfoNames.GetGenerated(type);
            var runtimeType = NormalizeRuntimeTypeName(type);
            if (!firstImplicitRuntimeTypeByName.TryGetValue(implicitName, out var firstRuntimeType) ||
                string.Equals(firstRuntimeType, runtimeType, StringComparison.Ordinal) ||
                collidingImplicitRuntimeTypesByName.TryGetValue(implicitName, out var collidingRuntimeTypes) &&
                collidingRuntimeTypes.Contains(runtimeType))
            {
                continue;
            }

            var baseName = SanitizeTypeInfoPropertyName(type).Replace("_", string.Empty);
            explicitNames[type] = ReserveExplicitTypeInfoPropertyName(
                usedNames,
                baseName,
                type);
        }

        // Phase 3: Handle collisions between explicit types and STJ's implicit nullable naming.
        // When STJ discovers Nullable<T> from JsonSerializerContextTypes, it names the TypeInfo
        // "Nullable{TypeName}". If another explicit type has that same implicit name, it collides.
        // Example: LLMModel? → STJ names it "NullableLLMModel", colliding with schema type NullableLLMModel.
        var implicitNullableNames = CreateStringSet(implicitlyDiscoveredTypes.Count);
        foreach (var type in implicitlyDiscoveredTypes)
        {
            if (!ShouldKeepDefaultTypeInfoPropertyName(type))
            {
                implicitNullableNames.Add($"Nullable{typeInfoNames.GetImplicit(type)}");
            }
        }

        foreach (var type in types)
        {
            if (explicitNames.ContainsKey(type))
            {
                continue;
            }

            var implicitName = typeInfoNames.GetGenerated(type);
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

    private static HashSet<string> GetJsonSerializableGuardTypes(
        string[] serializableTypes,
        string[] explicitNullableValueTypes,
        JsonTypeInfoNameCache typeInfoNames)
    {
        var explicitNullableValueTypeSet = CreateStringSet(explicitNullableValueTypes.Length);
        foreach (var type in explicitNullableValueTypes)
        {
            explicitNullableValueTypeSet.Add(type);
        }
        var generatedNameCounts = new Dictionary<string, (int Count, bool HasGuardCandidate)>(
            serializableTypes.Length,
            StringComparer.Ordinal);
        foreach (var type in serializableTypes)
        {
            var generatedName = typeInfoNames.GetGenerated(type);
            var isGuardCandidate =
                type.EndsWith("?", StringComparison.Ordinal) ||
                type.Contains("System.Collections.Generic.List<", StringComparison.Ordinal) ||
                type.Contains("System.Collections.Generic.IList<", StringComparison.Ordinal);
            generatedNameCounts[generatedName] = generatedNameCounts.TryGetValue(generatedName, out var current)
                ? (current.Count + 1, current.HasGuardCandidate || isGuardCandidate)
                : (1, isGuardCandidate);
        }

        var guardTypes = CreateStringSet(explicitNullableValueTypes.Length);
        foreach (var type in serializableTypes)
        {
            var generatedName = typeInfoNames.GetGenerated(type);
            var generatedNameState = generatedNameCounts[generatedName];
            if (explicitNullableValueTypeSet.Contains(type) ||
                generatedNameState is { Count: > 1, HasGuardCandidate: true } ||
                generatedName.Length > MaxGeneratedTypeInfoNameLength)
            {
                guardTypes.Add(type);
            }
        }

        return guardTypes;
    }

    private const int MaxExplicitTypeInfoPropertyNameLength = 120;
    private const int MaxGeneratedTypeInfoNameLength = 120;

    private static HashSet<string> CreateStringSet(int capacity)
    {
#if NET8_0_OR_GREATER
        return new HashSet<string>(capacity, StringComparer.Ordinal);
#else
        return new HashSet<string>(StringComparer.Ordinal);
#endif
    }

    private static string[] GetExplicitNullableValueTypes(
        string[] distinctTypes,
        string[] concreteListTypes,
        string[] nullableValueTypes,
        JsonTypeInfoNameCache typeInfoNames)
    {
        var explicitlyRegisteredNames = CreateStringSet(distinctTypes.Length + concreteListTypes.Length);
        foreach (var type in distinctTypes)
        {
            explicitlyRegisteredNames.Add(typeInfoNames.GetGenerated(type));
        }
        foreach (var type in concreteListTypes)
        {
            explicitlyRegisteredNames.Add(typeInfoNames.GetGenerated(type));
        }
        var nullableNameCounts = new Dictionary<string, int>(
            nullableValueTypes.Length,
            StringComparer.Ordinal);
        foreach (var type in nullableValueTypes)
        {
            var generatedName = typeInfoNames.GetGenerated(type);
            nullableNameCounts[generatedName] = nullableNameCounts.TryGetValue(generatedName, out var count)
                ? count + 1
                : 1;
        }

        return nullableValueTypes
            .Where(type =>
            {
                var generatedName = typeInfoNames.GetGenerated(type);
                return generatedName.Length > MaxGeneratedTypeInfoNameLength ||
                       explicitlyRegisteredNames.Contains(generatedName) ||
                       nullableNameCounts[generatedName] > 1;
            })
            .ToArray();
    }

    private static string[] GetNullableValueTypes(EquatableArray<TypeData> types)
    {
        // A schema context can initially classify an anyOf/oneOf as a value type and later
        // collapse it to a generated reference model with the same C# name. Treat the runtime
        // type as a value type only when no occurrence identifies that name as a reference type;
        // otherwise typeof(ReferenceType?) is invalid C#.
        var referenceTypes = CreateStringSet(checked(types.Length * 2));
        foreach (var type in types)
        {
            if (!type.IsValueType)
            {
                referenceTypes.Add(type.CSharpTypeWithoutNullability);
            }
            foreach (var boxedSubType in type.SubTypes)
            {
                var subType = boxedSubType.Unbox<TypeData>();
                if (!subType.IsValueType)
                {
                    referenceTypes.Add(subType.CSharpTypeWithoutNullability);
                }
            }
        }

        var seenNullableTypes = CreateStringSet(types.Length);
        var nullableTypes = new List<string>();
        foreach (var type in types)
        {
            if (type.IsValueType &&
                !referenceTypes.Contains(type.CSharpTypeWithoutNullability) &&
                type.CSharpTypeWithNullability != type.CSharpTypeWithoutNullability &&
                type.CSharpTypeWithNullability.EndsWith("?", StringComparison.Ordinal) &&
                seenNullableTypes.Add(type.CSharpTypeWithNullability))
            {
                nullableTypes.Add(type.CSharpTypeWithNullability);
            }
        }

        return nullableTypes.ToArray();
    }

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

    private static HashSet<string> GetCollidingJsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        string[] allDistinctTypes,
        string[] concreteListTypes,
        JsonTypeInfoNameCache typeInfoNames,
        JsonSerializableTypeComponents typeComponents)
    {
        var typeDataByNullableType = new Dictionary<string, TypeData>(
            types.Length,
            StringComparer.Ordinal);
        foreach (var type in types)
        {
#if NET462 || NETSTANDARD2_0
            if (!typeDataByNullableType.ContainsKey(type.CSharpTypeWithNullability))
            {
                typeDataByNullableType.Add(type.CSharpTypeWithNullability, type);
            }
#else
            typeDataByNullableType.TryAdd(type.CSharpTypeWithNullability, type);
#endif
        }

        var contextNameCounts = new Dictionary<string, int>(
            checked((allDistinctTypes.Length + concreteListTypes.Length) * 2),
            StringComparer.Ordinal);
        foreach (var type in allDistinctTypes)
        {
            CountContextNames(type);
        }
        foreach (var type in concreteListTypes)
        {
            CountContextNames(type);
        }

        var registeredRuntimeTypesByName = new Dictionary<string, (string RuntimeType, bool HasDifferentRuntimeType)>(
            checked(
                typeComponents.DistinctTypes.Length +
                typeComponents.ExplicitNullableValueTypes.Length +
                typeComponents.ConcreteListTypes.Length),
            StringComparer.Ordinal);
        foreach (var type in typeComponents.DistinctTypes)
        {
            AddRegisteredRuntimeType(type);
        }
        foreach (var type in typeComponents.ExplicitNullableValueTypes)
        {
            AddRegisteredRuntimeType(type);
        }
        foreach (var type in typeComponents.ConcreteListTypes)
        {
            AddRegisteredRuntimeType(type);
        }

        var skippedTypes = new HashSet<string>(StringComparer.Ordinal);
        foreach (var type in allDistinctTypes)
        {
            EvaluateCandidate(type);
        }
        foreach (var type in concreteListTypes)
        {
            EvaluateCandidate(type);
        }

        return skippedTypes;

        void GetContextNames(string type, out string first, out string? second)
        {
            typeDataByNullableType.TryGetValue(type, out var typeData);
            if (typeData is { IsValueType: true } &&
                type.EndsWith("?", StringComparison.Ordinal))
            {
                var nonNullableName = typeInfoNames.GetImplicit(type.Substring(0, type.Length - 1));
                first = $"Nullable{nonNullableName}";
                second = nonNullableName;
                return;
            }

            first = typeInfoNames.GetImplicit(type);
            second = null;
        }

        void CountContextNames(string type)
        {
            GetContextNames(type, out var first, out var second);
            IncrementNameCount(first);
            if (second is not null)
            {
                IncrementNameCount(second);
            }
        }

        void IncrementNameCount(string name)
        {
            contextNameCounts[name] = contextNameCounts.TryGetValue(name, out var count)
                ? count + 1
                : 1;
        }

        void AddRegisteredRuntimeType(string type)
        {
            var name = typeInfoNames.GetGenerated(type);
            var runtimeType = NormalizeRuntimeTypeName(type);
            if (!registeredRuntimeTypesByName.TryGetValue(name, out var registered))
            {
                registeredRuntimeTypesByName.Add(name, (runtimeType, false));
                return;
            }

            if (!string.Equals(registered.RuntimeType, runtimeType, StringComparison.Ordinal))
            {
                registeredRuntimeTypesByName[name] = (registered.RuntimeType, true);
            }
        }

        void EvaluateCandidate(string type)
        {
            var runtimeType = NormalizeRuntimeTypeName(type);
            GetContextNames(type, out var first, out var second);
            if (IsDuplicateContextName(first) ||
                second is not null && IsDuplicateContextName(second) ||
                HasDifferentRegisteredRuntimeType(first, runtimeType) ||
                second is not null && HasDifferentRegisteredRuntimeType(second, runtimeType))
            {
                skippedTypes.Add(type);
            }
        }

        bool IsDuplicateContextName(string name)
        {
            return contextNameCounts[name] > 1;
        }

        bool HasDifferentRegisteredRuntimeType(string name, string runtimeType)
        {
            return registeredRuntimeTypesByName.TryGetValue(name, out var registered) &&
                   (registered.HasDifferentRuntimeType ||
                    !string.Equals(registered.RuntimeType, runtimeType, StringComparison.Ordinal));
        }
    }

    private static string GetGeneratedTypeInfoPropertyName(string type)
    {
        if (type.EndsWith("?", StringComparison.Ordinal))
        {
            return $"Nullable{GetImplicitTypeInfoPropertyName(type.Substring(0, type.Length - 1))}";
        }

        return GetImplicitTypeInfoPropertyName(type);
    }

    internal sealed class JsonSerializerContextGenerationState
    {
        private string[]? _nullableValueTypes;
        private JsonSerializableTypeComponents? _jsonSerializableTypeComponents;

        public JsonTypeInfoNameCache TypeInfoNames { get; } = new();

        public string[] GetNullableValueTypes(EquatableArray<TypeData> types)
        {
            return _nullableValueTypes ??= types.IsEmpty
                ? Array.Empty<string>()
                : Sources.GetNullableValueTypes(types);
        }

        public JsonSerializableTypeComponents GetJsonSerializableTypeComponents(
            EquatableArray<TypeData> types)
        {
            if (_jsonSerializableTypeComponents is { } components)
            {
                return components;
            }

            var distinctTypes = types
                .Select(static type => type.CSharpTypeWithoutNullability)
                .Distinct(StringComparer.Ordinal)
                .ToArray();
            var concreteListTypes = GetConcreteListTypes(distinctTypes);
            components = new JsonSerializableTypeComponents(
                distinctTypes,
                concreteListTypes,
                GetExplicitNullableValueTypes(
                    distinctTypes,
                    concreteListTypes,
                    GetNullableValueTypes(types),
                    TypeInfoNames));
            _jsonSerializableTypeComponents = components;
            return components;
        }
    }

    internal readonly struct JsonSerializableTypeComponents
    {
        public JsonSerializableTypeComponents(
            string[] distinctTypes,
            string[] concreteListTypes,
            string[] explicitNullableValueTypes)
        {
            DistinctTypes = distinctTypes;
            ConcreteListTypes = concreteListTypes;
            ExplicitNullableValueTypes = explicitNullableValueTypes;
        }

        public string[] DistinctTypes { get; }

        public string[] ConcreteListTypes { get; }

        public string[] ExplicitNullableValueTypes { get; }
    }

    internal sealed class JsonTypeInfoNameCache
    {
        private readonly Dictionary<string, string> _generatedNames = new(StringComparer.Ordinal);
        private readonly Dictionary<string, string> _implicitNames = new(StringComparer.Ordinal);

        public string GetGenerated(string type)
        {
            if (!type.EndsWith("?", StringComparison.Ordinal))
            {
                return GetImplicit(type);
            }

            if (_generatedNames.TryGetValue(type, out var name))
            {
                return name;
            }

            name = $"Nullable{GetImplicit(type.Substring(0, type.Length - 1))}";
            _generatedNames.Add(type, name);

            return name;
        }

        public string GetImplicit(string type)
        {
            if (_implicitNames.TryGetValue(type, out var name))
            {
                return name;
            }

            name = CreateImplicit(type);
            _implicitNames.Add(type, name);

            return name;
        }

        private static string CreateImplicit(string type)
        {
            return CreateImplicitTypeInfoPropertyName(type);
        }
    }

    private static string NormalizeRuntimeTypeName(string type)
    {
        return type.EndsWith("?", StringComparison.Ordinal)
            ? type.Substring(0, type.Length - 1)
            : type;
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
        return CreateImplicitTypeInfoPropertyName(type);
    }

    private static string CreateImplicitTypeInfoPropertyName(string type)
    {
        using var builder = new PooledStringBuilder(type.Length + 16);
        AppendImplicitTypeInfoPropertyName(builder, type, 0, type.Length);
        return builder.ToString();
    }

    private static void AppendImplicitTypeInfoPropertyName(
        PooledStringBuilder builder,
        string type,
        int start,
        int length)
    {
        while (length > 0 && char.IsWhiteSpace(type[start]))
        {
            start++;
            length--;
        }
        while (length > 0 && char.IsWhiteSpace(type[start + length - 1]))
        {
            length--;
        }

        const string globalPrefix = "global::";
        if (length >= globalPrefix.Length &&
            type.AsSpan(start, globalPrefix.Length).SequenceEqual(globalPrefix.AsSpan()))
        {
            start += globalPrefix.Length;
            length -= globalPrefix.Length;
        }

        if (TryGetCSharpAliasTypeInfoPropertyName(type.AsSpan(start, length), out var aliasName))
        {
            builder.Append(aliasName);
            return;
        }

        if (length >= 2 &&
            type[start + length - 2] == '[' &&
            type[start + length - 1] == ']')
        {
            AppendImplicitTypeInfoPropertyName(builder, type, start, length - 2);
            builder.Append("Array");
            return;
        }

        if (length > 0 && type[start + length - 1] == '?')
        {
            AppendImplicitTypeInfoPropertyName(builder, type, start, length - 1);
            return;
        }

        var end = start + length;
        var genericStart = type.IndexOf('<', start, length);
        if (genericStart >= 0 && type[end - 1] == '>')
        {
            AppendSimpleTypeName(builder, type, start, genericStart - start);
            var argumentStart = genericStart + 1;
            var argumentEnd = end - 1;
            var depth = 0;
            for (var index = argumentStart; index < argumentEnd; index++)
            {
                switch (type[index])
                {
                    case '<':
                        depth++;
                        break;
                    case '>':
                        depth--;
                        break;
                    case ',' when depth == 0:
                        AppendImplicitTypeInfoPropertyName(
                            builder,
                            type,
                            argumentStart,
                            index - argumentStart);
                        argumentStart = index + 1;
                        break;
                }
            }

            AppendImplicitTypeInfoPropertyName(
                builder,
                type,
                argumentStart,
                argumentEnd - argumentStart);
            return;
        }

        AppendSimpleTypeName(builder, type, start, length);
    }

    private static void AppendSimpleTypeName(
        PooledStringBuilder builder,
        string type,
        int start,
        int length)
    {
        var end = start + length;
        var simpleStart = start;
        for (var index = end - 1; index >= start; index--)
        {
            if (type[index] is '.' or ':')
            {
                simpleStart = index + 1;
                break;
            }
        }

        var simpleLength = end - simpleStart;
        var arity = type.IndexOf('`', simpleStart, simpleLength);
        if (arity >= 0)
        {
            simpleLength = arity - simpleStart;
        }

        builder.Append(type, simpleStart, simpleLength);
    }

    private static bool TryGetCSharpAliasTypeInfoPropertyName(
        ReadOnlySpan<char> type,
        out string name)
    {
        name = type.Length switch
        {
            3 when type.SequenceEqual("int".AsSpan()) => "Int32",
            4 when type.SequenceEqual("bool".AsSpan()) => "Boolean",
            4 when type.SequenceEqual("byte".AsSpan()) => "Byte",
            4 when type.SequenceEqual("char".AsSpan()) => "Char",
            4 when type.SequenceEqual("long".AsSpan()) => "Int64",
            4 when type.SequenceEqual("nint".AsSpan()) => "IntPtr",
            4 when type.SequenceEqual("uint".AsSpan()) => "UInt32",
            4 when type.SequenceEqual("void".AsSpan()) => "Void",
            5 when type.SequenceEqual("float".AsSpan()) => "Single",
            5 when type.SequenceEqual("nuint".AsSpan()) => "UIntPtr",
            5 when type.SequenceEqual("sbyte".AsSpan()) => "SByte",
            5 when type.SequenceEqual("short".AsSpan()) => "Int16",
            5 when type.SequenceEqual("ulong".AsSpan()) => "UInt64",
            6 when type.SequenceEqual("double".AsSpan()) => "Double",
            6 when type.SequenceEqual("object".AsSpan()) => "Object",
            6 when type.SequenceEqual("string".AsSpan()) => "String",
            6 when type.SequenceEqual("ushort".AsSpan()) => "UInt16",
            7 when type.SequenceEqual("decimal".AsSpan()) => "Decimal",
            _ => string.Empty,
        };

        return name.Length > 0;
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
