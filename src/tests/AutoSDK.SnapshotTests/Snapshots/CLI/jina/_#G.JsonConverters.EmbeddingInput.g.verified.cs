//HintName: G.JsonConverters.EmbeddingInput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingInput>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.TextEmbeddingInput? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageEmbeddingInput? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MixedEmbeddingInput? mixed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                mixed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.EmbeddingInput(
                text,
                image,
                mixed
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mixed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsMixed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mixed, typeInfo);
            }
        }
    }
}