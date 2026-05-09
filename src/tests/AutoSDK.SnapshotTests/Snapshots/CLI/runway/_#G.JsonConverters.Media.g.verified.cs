//HintName: G.JsonConverters.Media.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MediaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Media>
    {
        /// <inheritdoc />
        public override global::G.Media Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? audio = default;
            if (discriminator?.Type == "audio")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? video = default;
            if (discriminator?.Type == "video")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Media(
                discriminator?.Type,
                audio,

                video
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Media value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
        }
    }
}