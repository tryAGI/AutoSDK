//HintName: G.JsonConverters.FinetuneResponseTrainingType.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FinetuneResponseTrainingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FinetuneResponseTrainingType>
    {
        /// <inheritdoc />
        public override global::G.FinetuneResponseTrainingType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.FullTrainingType? full = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FullTrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FullTrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FullTrainingType).Name}");
                full = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LoRATrainingType? loRA = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LoRATrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LoRATrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LoRATrainingType).Name}");
                loRA = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.FinetuneResponseTrainingType(
                full,
                loRA
                );

            if (full != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FullTrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FullTrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FullTrainingType).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (loRA != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LoRATrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LoRATrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LoRATrainingType).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FinetuneResponseTrainingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFull)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FullTrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FullTrainingType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FullTrainingType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Full, typeInfo);
            }
            else if (value.IsLoRA)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LoRATrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LoRATrainingType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LoRATrainingType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LoRA, typeInfo);
            }
        }
    }
}