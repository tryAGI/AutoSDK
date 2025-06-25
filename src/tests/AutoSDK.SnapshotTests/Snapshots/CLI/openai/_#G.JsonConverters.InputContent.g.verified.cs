//HintName: G.JsonConverters.InputContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputContent>
    {
        /// <inheritdoc />
        public override global::G.InputContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.InputTextContent? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputTextContent).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputImageContent? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImageContent).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputFileContent? file = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFileContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFileContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFileContent).Name}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.InputContent(
                text,
                image,
                file
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputTextContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImageContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (file != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFileContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFileContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFileContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputTextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputTextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFileContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFileContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFileContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
        }
    }
}