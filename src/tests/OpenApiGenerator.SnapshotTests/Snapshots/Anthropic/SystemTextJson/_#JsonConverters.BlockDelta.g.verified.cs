//HintName: JsonConverters.BlockDelta.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class BlockDeltaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BlockDelta>
    {
        /// <inheritdoc />
        public override global::G.BlockDelta Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.TextBlockDelta? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlockDelta).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputJsonBlockDelta? inputJson = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputJsonBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputJsonBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputJsonBlockDelta).Name}");
                inputJson = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.BlockDelta(
                text,
                inputJson
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlockDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputJson != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputJsonBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputJsonBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputJsonBlockDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BlockDelta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsInputJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputJsonBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputJsonBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputJsonBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJson, typeInfo);
            }
        }
    }
}