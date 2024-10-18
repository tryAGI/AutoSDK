//HintName: JsonConverters.ToolContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolContent>
    {
        /// <inheritdoc />
        public override global::G.ToolContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.ToolContentDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DocumentContent? document = default;
            if (discriminator?.Type == global::G.ToolContentDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DocumentContent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolContent(
                discriminator?.Type,
                text,
                document
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
        }
    }
}