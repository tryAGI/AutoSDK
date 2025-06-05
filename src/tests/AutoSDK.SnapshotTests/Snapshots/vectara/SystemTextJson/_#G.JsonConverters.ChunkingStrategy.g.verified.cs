//HintName: G.JsonConverters.ChunkingStrategy.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::G.ChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MaxCharsChunkingStrategy? maxCharsChunkingStrategy = default;
            if (discriminator?.Type == global::G.ChunkingStrategyDiscriminatorType.MaxCharsChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MaxCharsChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MaxCharsChunkingStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MaxCharsChunkingStrategy)}");
                maxCharsChunkingStrategy = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SentenceChunkingStrategy? sentenceChunkingStrategy = default;
            if (discriminator?.Type == global::G.ChunkingStrategyDiscriminatorType.SentenceChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SentenceChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SentenceChunkingStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SentenceChunkingStrategy)}");
                sentenceChunkingStrategy = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ChunkingStrategy(
                discriminator?.Type,
                maxCharsChunkingStrategy,
                sentenceChunkingStrategy
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMaxCharsChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MaxCharsChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MaxCharsChunkingStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MaxCharsChunkingStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCharsChunkingStrategy, typeInfo);
            }
            else if (value.IsSentenceChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SentenceChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SentenceChunkingStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SentenceChunkingStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SentenceChunkingStrategy, typeInfo);
            }
        }
    }
}