//HintName: G.JsonConverters.Request6.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Request6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request6>
    {
        /// <inheritdoc />
        public override global::G.Request6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestElevenTextToSoundV2? elevenTextToSoundV2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenTextToSoundV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenTextToSoundV2).Name}");
                elevenTextToSoundV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request6(
                elevenTextToSoundV2
                );

            if (elevenTextToSoundV2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenTextToSoundV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenTextToSoundV2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenTextToSoundV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenTextToSoundV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenTextToSoundV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenTextToSoundV2, typeInfo);
            }
        }
    }
}