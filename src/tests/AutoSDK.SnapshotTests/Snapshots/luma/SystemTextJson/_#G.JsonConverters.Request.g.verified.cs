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
            global::G.GenerationRequest? video = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageGenerationRequest? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request(
                video,

                image
                );

            if (video != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}