//HintName: G.JsonConverters.CreateSoundEffectRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateSoundEffectRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSoundEffectRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateSoundEffectRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSoundEffectRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateSoundEffectRequestElevenTextToSoundV2? elevenTextToSoundV2 = default;
            if (discriminator?.Model == "eleven_text_to_sound_v2")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestElevenTextToSoundV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSoundEffectRequestElevenTextToSoundV2)}");
                elevenTextToSoundV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateSoundEffectRequest(
                discriminator?.Model,
                elevenTextToSoundV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSoundEffectRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenTextToSoundV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestElevenTextToSoundV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenTextToSoundV2!, typeInfo);
            }
        }
    }
}