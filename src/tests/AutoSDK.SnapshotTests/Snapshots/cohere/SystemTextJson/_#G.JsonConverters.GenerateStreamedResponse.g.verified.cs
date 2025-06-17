//HintName: G.JsonConverters.GenerateStreamedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateStreamedResponse>
    {
        /// <inheritdoc />
        public override global::G.GenerateStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GenerateStreamText? textGeneration = default;
            if (discriminator?.EventType == global::G.GenerateStreamedResponseDiscriminatorEventType.TextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateStreamText)}");
                textGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateStreamEnd? streamEnd = default;
            if (discriminator?.EventType == global::G.GenerateStreamedResponseDiscriminatorEventType.StreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateStreamEnd)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateStreamError? streamError = default;
            if (discriminator?.EventType == global::G.GenerateStreamedResponseDiscriminatorEventType.StreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateStreamError)}");
                streamError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.GenerateStreamedResponse(
                discriminator?.EventType,
                textGeneration,
                streamEnd,
                streamError
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGeneration, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsStreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamError, typeInfo);
            }
        }
    }
}