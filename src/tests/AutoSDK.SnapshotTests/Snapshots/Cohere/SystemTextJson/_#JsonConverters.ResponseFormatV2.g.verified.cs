//HintName: JsonConverters.ResponseFormatV2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormatV2>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormatV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatV2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatV2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFormatV2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextResponseFormatV2? text = default;
            if (discriminator?.Type == global::G.ResponseFormatV2DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextResponseFormatV2)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.JsonResponseFormatV2? json = default;
            if (discriminator?.Type == global::G.ResponseFormatV2DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JsonResponseFormatV2)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ResponseFormatV2(
                discriminator?.Type,
                text,
                json
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormatV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormatV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormatV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonResponseFormatV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JsonResponseFormatV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeInfo);
            }
        }
    }
}