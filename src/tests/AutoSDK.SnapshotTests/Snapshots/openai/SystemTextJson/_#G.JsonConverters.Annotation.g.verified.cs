//HintName: G.JsonConverters.Annotation.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Annotation>
    {
        /// <inheritdoc />
        public override global::G.Annotation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.FileCitationBody? fileCitationBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                fileCitationBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UrlCitationBody? urlCitationBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                urlCitationBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContainerFileCitationBody? containerFileCitationBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContainerFileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContainerFileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContainerFileCitationBody).Name}");
                containerFileCitationBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.FilePath? filePath = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilePath), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilePath> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilePath).Name}");
                filePath = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Annotation(
                fileCitationBody,
                urlCitationBody,
                containerFileCitationBody,
                filePath
                );

            if (fileCitationBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (urlCitationBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (containerFileCitationBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContainerFileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContainerFileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContainerFileCitationBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (filePath != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilePath), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilePath> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilePath).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Annotation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitationBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitationBody, typeInfo);
            }
            else if (value.IsUrlCitationBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitationBody, typeInfo);
            }
            else if (value.IsContainerFileCitationBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContainerFileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContainerFileCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContainerFileCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerFileCitationBody, typeInfo);
            }
            else if (value.IsFilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilePath), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilePath?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilePath).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePath, typeInfo);
            }
        }
    }
}