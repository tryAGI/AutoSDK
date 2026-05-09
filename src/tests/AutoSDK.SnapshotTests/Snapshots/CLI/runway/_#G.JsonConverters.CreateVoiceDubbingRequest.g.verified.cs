//HintName: G.JsonConverters.CreateVoiceDubbingRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateVoiceDubbingRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVoiceDubbingRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateVoiceDubbingRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceDubbingRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceDubbingRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVoiceDubbingRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateVoiceDubbingRequestElevenVoiceDubbing? elevenVoiceDubbing = default;
            if (discriminator?.Model == "eleven_voice_dubbing")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceDubbingRequestElevenVoiceDubbing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing)}");
                elevenVoiceDubbing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateVoiceDubbingRequest(
                discriminator?.Model,
                elevenVoiceDubbing
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVoiceDubbingRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenVoiceDubbing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenVoiceDubbing!, typeInfo);
            }
        }
    }
}