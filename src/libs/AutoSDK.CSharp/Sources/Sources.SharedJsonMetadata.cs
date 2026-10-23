using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Internal;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    internal sealed class SharedJsonMetadataPlan
    {
        internal IReadOnlyDictionary<string, string> FactoryMethods { get; }
        internal FileWithName Manifest { get; }
        internal FileWithName Runtime { get; }
        internal FileWithName PackageBinding { get; }
        internal string ScopeTypeName { get; }

        internal SharedJsonMetadataPlan(IReadOnlyDictionary<string, string> factoryMethods, FileWithName manifest,
            FileWithName runtime, string scopeTypeName)
        {
            FactoryMethods = factoryMethods;
            Manifest = manifest;
            Runtime = runtime;
            PackageBinding = CreateSharedJsonMetadataPackageBinding();
            ScopeTypeName = scopeTypeName;
        }
    }

    internal static SharedJsonMetadataPlan CreateSharedJsonMetadataPlan(Models.Data data)
    {
        // Always metadata: a shared factory cannot contain instance-bound fast-path writers.
        var client = data.Converters with
        {
            Settings = data.Converters.Settings with { DirectionAwareJsonGenerationMode = true },
        };
        var state = new JsonSerializerContextGenerationState();
        var nullable = state.GetNullableValueTypes(data.Types);
        var typeSet = BuildJsonSerializableTypeSet(client, expandContextTypes: true,
            state.GetJsonSerializableTypeComponents(data.Types), nullable);
        var deprecated = data.Classes.Where(static model => model.IsDeprecated).ToArray();
        var registrations = GenerateJsonSerializableAttributeRegistrations(client, data.Types, typeSet,
            state.TypeInfoNames, nullable, deprecated.Select(static model => model.GlobalClassName).ToArray());
        // One STJ context discovers each compiled dependency once. The analyzer moves each
        // factory into an independent holder before C# compilation, avoiding both repeated
        // chunk closures and a giant compiler-generated closure type.
        var chunks = new[] { registrations };
        var factories = new Dictionary<string, string>(StringComparer.Ordinal);
        using var builder = new PooledStringBuilder(4096 + registrations.Length * 160);
        builder.Append(SharedJsonMetadataProtocol.HeaderPrefix +
            SharedJsonMetadataProtocol.CurrentVersion.ToString(System.Globalization.CultureInfo.InvariantCulture) + "\n");
        builder.Append($@"
#nullable enable
namespace {client.Settings.Namespace}
{{");
        var prefix = GetJsonSerializerContextClassName(client) + "Metadata";
        for (var index = 0; index < chunks.Length; index++)
        {
            var className = prefix + index.ToString(System.Globalization.CultureInfo.InvariantCulture);
            builder.Append(@"
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
");
            // Direction-specific overrides cannot enable writers in the factory-only profile.
            var attributes = chunks[index].Select(registration =>
            {
                // Constructed generics need explicit names because STJ normalizes nested
                // nullable arguments differently. Keep conventional names for built-in types:
                // STJ also uses their type-info names to select JsonMetadataServices converters.
                var name = registration.TypeInfoPropertyName ?? state.TypeInfoNames.GetGenerated(registration.Type);
                if (registration.Type.Contains("<"))
                {
                    var identity = Packaging.SerializerContextPlan.GetContextName(client.Settings,
                        "MetadataType", registration.Type);
                    name = identity.Substring(identity.LastIndexOf('.') + 1);
                }
                return new JsonSerializableAttributeRegistration(registration.Type, name, generationMode: null,
                    registration.IsGuard, registration.IsDeprecated);
            }).ToArray();
            var names = attributes.Select(static registration => registration.TypeInfoPropertyName!)
                .Distinct(StringComparer.Ordinal).OrderBy(static name => name, StringComparer.Ordinal).ToArray();
            var holders = new Dictionary<string, string>(StringComparer.Ordinal);
            for (var offset = 0; offset < names.Length; offset += SharedJsonMetadataProtocol.FactoryBatchSize)
            {
                var batch = offset / SharedJsonMetadataProtocol.FactoryBatchSize;
                var members = names.Skip(offset).Take(SharedJsonMetadataProtocol.FactoryBatchSize).ToArray();
                builder.Append(SharedJsonMetadataProtocol.BatchPrefix + client.Settings.Namespace + "." + className +
                    "|" + batch.ToString(System.Globalization.CultureInfo.InvariantCulture) + "|" +
                    string.Join(",", members) + "\n");
                foreach (var member in members)
                {
                    holders.Add(member, SharedJsonMetadataProtocol.FactoryBatchHolderName(className, batch));
                }
            }
            AppendJsonSerializableAttributes(builder, attributes);
            builder.Append($@"
    internal sealed partial class {className} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
");
            foreach (var registration in attributes)
            {
                if (!factories.ContainsKey(registration.Type))
                {
                    var name = registration.TypeInfoPropertyName ?? state.TypeInfoNames.GetGenerated(registration.Type);
                    factories.Add(registration.Type,
                        $"global::{client.Settings.Namespace}.{holders[name]}.Create_{name}");
                }
            }
        }
        builder.Append($@"
    // Missing support means the CLI and analyzer package are not protocol-compatible.
    internal static class {prefix}ProtocolGuard
    {{
        internal const int Version = {SharedJsonMetadataProtocol.GeneratedProtocolTypeName}.Version{SharedJsonMetadataProtocol.CurrentVersion};
    }}
}}");
        return new SharedJsonMetadataPlan(factories,
            new FileWithName(client.Settings.Namespace + ".autosdk-json-metadata", builder.ToString()),
            SharedJsonMetadataRuntime(client, factories), "global::" + client.Settings.Namespace + "." +
                GetJsonSerializerContextClassName(client) + "MetadataScope");
    }

    private static void AppendSharedMetadataResolver(PooledStringBuilder builder,
        JsonSerializableAttributeRegistration[] registrations, SharedJsonMetadataPlan metadata) =>
        AppendSharedMetadataResolver(builder, registrations, metadata.FactoryMethods);

    private static void AppendSharedMetadataResolver(PooledStringBuilder builder,
        JsonSerializableAttributeRegistration[] registrations, IReadOnlyDictionary<string, string> factoryMethods)
    {
        builder.Append(@"
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {");
        foreach (var registration in registrations)
        {
            if (!factoryMethods.TryGetValue(registration.Type, out var factory))
            {
                throw new InvalidOperationException(
                    "A scoped JSON type has no shared metadata factory: " + registration.Type);
            }
            if (registration.IsDeprecated)
            {
                builder.Append("\n                #pragma warning disable CS0618 // Metadata references a deprecated API model.");
            }
            builder.Append($@"
                if (type == typeof({registration.Type}))
                {{
                    return {factory}(options);
                }}");
            if (registration.IsDeprecated)
            {
                builder.Append("\n                #pragma warning restore CS0618");
            }
        }
        builder.Append(@"
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }
");
    }
}
