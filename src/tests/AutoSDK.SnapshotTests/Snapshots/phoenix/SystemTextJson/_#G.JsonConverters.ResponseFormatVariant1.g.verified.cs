//HintName: G.JsonConverters.ResponseFormatVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormatVariant1>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormatVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptVersionResponseFormatVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptVersionResponseFormatVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptVersionResponseFormatVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PromptResponseFormatJSONSchema? jsonSchema = default;
            if (discriminator?.Type == global::G.PromptVersionResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptResponseFormatJSONSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptResponseFormatJSONSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResponseFormatVariant1(
                discriminator?.Type,
                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormatVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptResponseFormatJSONSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptResponseFormatJSONSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeInfo);
            }
        }
    }
}