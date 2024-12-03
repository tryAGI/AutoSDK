//HintName: JsonConverters.Request.g.cs
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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GenerationRequest? video = default;
            if (discriminator?.Generation_type == global::G.GenerationRequestDiscriminatorGeneration_type.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationRequest)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageGenerationRequest? image = default;
            if (discriminator?.Generation_type == global::G.GenerationRequestDiscriminatorGeneration_type.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageGenerationRequest)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Request(
                discriminator?.Generation_type,
                video,
                image
                );

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