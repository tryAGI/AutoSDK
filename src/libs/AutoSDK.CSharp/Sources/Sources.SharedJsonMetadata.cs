using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    internal sealed class SharedJsonMetadataPlan
    {
        internal IReadOnlyDictionary<string, string> FactoryMethods { get; }
        internal FileWithName Manifest { get; }

        internal SharedJsonMetadataPlan(IReadOnlyDictionary<string, string> factoryMethods, FileWithName manifest)
        {
            FactoryMethods = factoryMethods;
            Manifest = manifest;
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
        var chunks = SplitJsonSerializableAttributes(registrations, client.Settings.JsonSerializerContextChunkSize).ToArray();
        var factories = new Dictionary<string, string>(StringComparer.Ordinal);
        using var builder = new PooledStringBuilder(4096 + registrations.Length * 160);
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
                var name = registration.TypeInfoPropertyName;
                if (registration.Type.Contains("<"))
                {
                    var identity = Packaging.SerializerContextPlan.GetContextName(client.Settings,
                        "MetadataType", registration.Type);
                    name = identity.Substring(identity.LastIndexOf('.') + 1);
                }
                return new JsonSerializableAttributeRegistration(registration.Type, name, generationMode: null,
                    registration.IsGuard, registration.IsDeprecated);
            }).ToArray();
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
                        $"global::{client.Settings.Namespace}.{className}.Create_{name}");
                }
            }
        }
        builder.Append(@"
}");
        return new SharedJsonMetadataPlan(factories,
            new FileWithName(client.Settings.Namespace + ".autosdk-json-metadata", builder.ToString()));
    }

    private static void AppendSharedMetadataResolver(PooledStringBuilder builder,
        JsonSerializableAttributeRegistration[] registrations, SharedJsonMetadataPlan metadata)
    {
        builder.Append(@"
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {");
        foreach (var registration in registrations)
        {
            if (!metadata.FactoryMethods.TryGetValue(registration.Type, out var factory))
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
