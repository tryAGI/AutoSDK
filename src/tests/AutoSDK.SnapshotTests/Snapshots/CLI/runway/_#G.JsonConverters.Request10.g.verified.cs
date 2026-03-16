//HintName: G.JsonConverters.Request10.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Request10JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request10>
    {
        /// <inheritdoc />
        public override global::G.Request10 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestElevenVoiceIsolation? elevenVoiceIsolation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenVoiceIsolation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenVoiceIsolation).Name}");
                elevenVoiceIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request10(
                elevenVoiceIsolation
                );

            if (elevenVoiceIsolation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenVoiceIsolation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenVoiceIsolation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request10 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenVoiceIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestElevenVoiceIsolation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestElevenVoiceIsolation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenVoiceIsolation, typeInfo);
            }
        }
    }
}