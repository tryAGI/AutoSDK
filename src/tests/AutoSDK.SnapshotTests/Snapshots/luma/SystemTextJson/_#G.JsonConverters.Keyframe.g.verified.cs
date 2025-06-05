//HintName: G.JsonConverters.Keyframe.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class KeyframeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Keyframe>
    {
        /// <inheritdoc />
        public override global::G.Keyframe Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyframeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyframeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.KeyframeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GenerationReference? generation = default;
            if (discriminator?.Type == global::G.KeyframeDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationReference)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageReference? image = default;
            if (discriminator?.Type == global::G.KeyframeDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageReference)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Keyframe(
                discriminator?.Type,
                generation,
                image
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Keyframe value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}