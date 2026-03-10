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
            global::G.FileCitationBody? fileCitation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UrlCitationBody? urlCitation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                urlCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContainerFileCitationBody? containerFileCitation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContainerFileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContainerFileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContainerFileCitationBody).Name}");
                containerFileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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

            var __value = new global::G.Annotation(
                fileCitation,

                urlCitation,

                containerFileCitation,

                filePath
                );

            if (fileCitation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (urlCitation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (containerFileCitation != null)
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Annotation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsUrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation, typeInfo);
            }
            else if (value.IsContainerFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContainerFileCitationBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContainerFileCitationBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContainerFileCitationBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerFileCitation, typeInfo);
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