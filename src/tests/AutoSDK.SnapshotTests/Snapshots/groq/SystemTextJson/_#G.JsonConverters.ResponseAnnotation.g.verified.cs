//HintName: G.JsonConverters.ResponseAnnotation.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseAnnotationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseAnnotation>
    {
        /// <inheritdoc />
        public override global::G.ResponseAnnotation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResponseFileCitation? fileCitation = default;
            if (discriminator?.Type == global::G.ResponseAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFileCitation)}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseUrlCitation? urlCitation = default;
            if (discriminator?.Type == global::G.ResponseAnnotationDiscriminatorType.UrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseUrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseUrlCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseUrlCitation)}");
                urlCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResponseAnnotation(
                discriminator?.Type,
                fileCitation,

                urlCitation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseAnnotation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsUrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseUrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseUrlCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseUrlCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation, typeInfo);
            }
        }
    }
}