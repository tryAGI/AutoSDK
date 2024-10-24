//HintName: JsonConverters.CreateDocumentRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateDocumentRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateDocumentRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateDocumentRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDocumentRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDocumentRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateDocumentRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CoreDocument? core = default;
            if (discriminator?.Type == global::G.CreateDocumentRequestDiscriminatorType.Core)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CoreDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CoreDocument> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CoreDocument)}");
                core = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StructuredDocument? structured = default;
            if (discriminator?.Type == global::G.CreateDocumentRequestDiscriminatorType.Structured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredDocument> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StructuredDocument)}");
                structured = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CreateDocumentRequest(
                discriminator?.Type,
                core,
                structured
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateDocumentRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CoreDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CoreDocument?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CoreDocument).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Core, typeInfo);
            }
            else if (value.IsStructured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredDocument?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StructuredDocument).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Structured, typeInfo);
            }
        }
    }
}