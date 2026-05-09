//HintName: G.JsonConverters.CreateVoiceIsolationRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateVoiceIsolationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVoiceIsolationRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateVoiceIsolationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceIsolationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceIsolationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVoiceIsolationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateVoiceIsolationRequestElevenVoiceIsolation? elevenVoiceIsolation = default;
            if (discriminator?.Model == "eleven_voice_isolation")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceIsolationRequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceIsolationRequestElevenVoiceIsolation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVoiceIsolationRequestElevenVoiceIsolation)}");
                elevenVoiceIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateVoiceIsolationRequest(
                discriminator?.Model,
                elevenVoiceIsolation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVoiceIsolationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenVoiceIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceIsolationRequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceIsolationRequestElevenVoiceIsolation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVoiceIsolationRequestElevenVoiceIsolation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenVoiceIsolation!, typeInfo);
            }
        }
    }
}