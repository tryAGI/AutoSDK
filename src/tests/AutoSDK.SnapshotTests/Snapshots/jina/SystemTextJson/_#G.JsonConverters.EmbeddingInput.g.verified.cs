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
            global::G.TextEmbeddingInput? textEmbeddingInput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                textEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ImageEmbeddingInput? imageEmbeddingInput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                imageEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MixedEmbeddingInput? mixedEmbeddingInput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                mixedEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.EmbeddingInput(
                textEmbeddingInput,
                imageEmbeddingInput,
                mixedEmbeddingInput
                );

            if (textEmbeddingInput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (imageEmbeddingInput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mixedEmbeddingInput != null)
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

            if (value.IsTextEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEmbeddingInput, typeInfo);
            }
            else if (value.IsImageEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageEmbeddingInput, typeInfo);
            }
            else if (value.IsMixedEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MixedEmbeddingInput, typeInfo);
            }
        }
    }
}