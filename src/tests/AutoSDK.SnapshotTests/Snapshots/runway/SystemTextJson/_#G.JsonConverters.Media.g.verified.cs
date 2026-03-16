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

            var
            readerCopy = reader;
            global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? audio = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio).Name}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? video = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo).Name}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Media(
                audio,

                video
                );

            if (audio != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (video != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
        }
    }
}