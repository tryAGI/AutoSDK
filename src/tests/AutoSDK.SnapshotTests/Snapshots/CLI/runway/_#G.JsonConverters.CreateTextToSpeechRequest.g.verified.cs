//HintName: G.JsonConverters.CreateTextToSpeechRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToSpeechRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToSpeechRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToSpeechRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToSpeechRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToSpeechRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToSpeechRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateTextToSpeechRequestElevenMultilingualV2? elevenMultilingualV2 = default;
            if (discriminator?.Model == global::G.CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToSpeechRequestElevenMultilingualV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToSpeechRequestElevenMultilingualV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToSpeechRequestElevenMultilingualV2)}");
                elevenMultilingualV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateTextToSpeechRequest(
                discriminator?.Model,
                elevenMultilingualV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToSpeechRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToSpeechRequestElevenMultilingualV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToSpeechRequestElevenMultilingualV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToSpeechRequestElevenMultilingualV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenMultilingualV2!, typeInfo);
            }
        }
    }
}