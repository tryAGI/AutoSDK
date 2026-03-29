//HintName: G.JsonConverters.ElevenLabsGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ElevenLabsGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ElevenLabsGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.ElevenLabsGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ElevenLabsGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ElevenLabsTextToSpeechOptions? textToSpeech = default;
            if (discriminator?.Type == global::G.ElevenLabsGeneratedAssetOptionsDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsTextToSpeechOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ElevenLabsTextToSpeechOptions)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ElevenLabsGeneratedAssetOptions(
                discriminator?.Type,
                textToSpeech
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ElevenLabsGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsTextToSpeechOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ElevenLabsTextToSpeechOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech, typeInfo);
            }
        }
    }
}