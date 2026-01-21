//HintName: G.JsonConverters.Request.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request>
    {
        /// <inheritdoc />
        public override global::G.Request Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.GenerationRequest? generation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageGenerationRequest? imageGeneration = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Request(
                generation,
                imageGeneration
                );

            if (generation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (imageGeneration != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration, typeInfo);
            }
        }
    }
}