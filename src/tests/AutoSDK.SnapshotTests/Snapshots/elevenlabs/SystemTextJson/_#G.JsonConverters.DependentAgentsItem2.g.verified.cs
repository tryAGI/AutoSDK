//HintName: G.JsonConverters.DependentAgentsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DependentAgentsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DependentAgentsItem2>
    {
        /// <inheritdoc />
        public override global::G.DependentAgentsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DependentAvailableAgentIdentifier? available = default;
            if (discriminator?.Type == global::G.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableAgentIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentAvailableAgentIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DependentUnknownAgentIdentifier? unknown = default;
            if (discriminator?.Type == global::G.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownAgentIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentUnknownAgentIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.DependentAgentsItem2(
                discriminator?.Type,
                available,
                unknown
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DependentAgentsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableAgentIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentAvailableAgentIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownAgentIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentUnknownAgentIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}