//HintName: G.JsonConverters.OutputContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputContent>
    {
        /// <inheritdoc />
        public override global::G.OutputContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.OutputTextContent? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputTextContent).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RefusalContent? refusal = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RefusalContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RefusalContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RefusalContent).Name}");
                refusal = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.OutputContent(
                text,
                refusal
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputTextContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusal != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RefusalContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RefusalContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RefusalContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputTextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputTextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsRefusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RefusalContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RefusalContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RefusalContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refusal, typeInfo);
            }
        }
    }
}