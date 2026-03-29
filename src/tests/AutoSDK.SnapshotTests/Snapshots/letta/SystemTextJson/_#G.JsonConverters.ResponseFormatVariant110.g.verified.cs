//HintName: G.JsonConverters.ResponseFormatVariant110.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant110JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormatVariant110>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormatVariant110 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseFormatVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseFormatVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ModelResponseFormatVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextResponseFormat? text = default;
            if (discriminator?.Type == global::G.ModelResponseFormatVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextResponseFormat)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.JsonSchemaResponseFormat? jsonSchema = default;
            if (discriminator?.Type == global::G.ModelResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonSchemaResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonSchemaResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JsonSchemaResponseFormat)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.JsonObjectResponseFormat? jsonObject = default;
            if (discriminator?.Type == global::G.ModelResponseFormatVariant1DiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonObjectResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonObjectResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JsonObjectResponseFormat)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResponseFormatVariant110(
                discriminator?.Type,
                text,

                jsonSchema,

                jsonObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormatVariant110 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonSchemaResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonSchemaResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JsonSchemaResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JsonObjectResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JsonObjectResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JsonObjectResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeInfo);
            }
        }
    }
}