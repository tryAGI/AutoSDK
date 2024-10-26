//HintName: JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? auto = default;
            if (discriminator?.Type == global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1)}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? @static = default;
            if (discriminator?.Type == global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2)}");
                @static = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
                discriminator?.Type,
                auto,
                @static
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeInfo);
            }
            else if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeInfo);
            }
        }
    }
}