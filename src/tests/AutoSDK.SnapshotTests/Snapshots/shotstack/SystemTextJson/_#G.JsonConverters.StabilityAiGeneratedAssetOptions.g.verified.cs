//HintName: G.JsonConverters.StabilityAiGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StabilityAiGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StabilityAiGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.StabilityAiGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StabilityAiGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.StabilityAiTextToImageOptions? textToImage = default;
            if (discriminator?.Type == global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType.TextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiTextToImageOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StabilityAiTextToImageOptions)}");
                textToImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.StabilityAiGeneratedAssetOptions(
                discriminator?.Type,
                textToImage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StabilityAiGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiTextToImageOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StabilityAiTextToImageOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToImage!, typeInfo);
            }
        }
    }
}