//HintName: G.JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ToolSource? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DocumentSource? document = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Source(
                tool,
                document
                );

            if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (document != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
        }
    }
}