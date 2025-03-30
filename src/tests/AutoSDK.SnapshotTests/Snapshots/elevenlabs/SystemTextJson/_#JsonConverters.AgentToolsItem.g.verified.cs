//HintName: JsonConverters.AgentToolsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentToolsItem>
    {
        /// <inheritdoc />
        public override global::G.AgentToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DependentAvailableAgentToolIdentifier? available = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableAgentToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentAvailableAgentToolIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DependentUnknownAgentToolIdentifier? unknown = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownAgentToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentUnknownAgentToolIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.AgentToolsItem(
                discriminator?.Type,
                available,
                unknown
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableAgentToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentAvailableAgentToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownAgentToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentUnknownAgentToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}