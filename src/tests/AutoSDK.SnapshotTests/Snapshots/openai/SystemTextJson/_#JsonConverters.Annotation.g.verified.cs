//HintName: JsonConverters.Annotation.g.cs
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
            global::G.FileCitation? fileCitation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitation).Name}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UrlCitation? urlCitation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitation).Name}");
                urlCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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
                fileCitation,
                urlCitation,
                filePath
                );

            if (fileCitation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (urlCitation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitation).Name}");
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

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsUrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation, typeInfo);
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