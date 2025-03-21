//HintName: JsonConverters.InputContent.g.cs
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
            global::G.InputText? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputImage? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImage).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputFile? file = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (file != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
        }
    }
}