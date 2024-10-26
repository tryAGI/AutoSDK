//HintName: JsonConverters.VectorStoreFileObjectChunkingStrategy.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class VectorStoreFileObjectChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VectorStoreFileObjectChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::G.VectorStoreFileObjectChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VectorStoreFileObjectChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VectorStoreFileObjectChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VectorStoreFileObjectChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.StaticChunkingStrategyResponseParam? @static = default;
            if (discriminator?.Type == global::G.VectorStoreFileObjectChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StaticChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StaticChunkingStrategyResponseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StaticChunkingStrategyResponseParam)}");
                @static = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OtherChunkingStrategyResponseParam? other = default;
            if (discriminator?.Type == global::G.VectorStoreFileObjectChunkingStrategyDiscriminatorType.Other)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OtherChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OtherChunkingStrategyResponseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OtherChunkingStrategyResponseParam)}");
                other = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.VectorStoreFileObjectChunkingStrategy(
                discriminator?.Type,
                @static,
                other
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VectorStoreFileObjectChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StaticChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StaticChunkingStrategyResponseParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StaticChunkingStrategyResponseParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeInfo);
            }
            else if (value.IsOther)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OtherChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OtherChunkingStrategyResponseParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OtherChunkingStrategyResponseParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Other, typeInfo);
            }
        }
    }
}