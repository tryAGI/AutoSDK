//HintName: G.JsonConverters.GetDocumentationFromKnowledgeBaseResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetDocumentationFromKnowledgeBaseResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetDocumentationFromKnowledgeBaseResponse>
    {
        /// <inheritdoc />
        public override global::G.GetDocumentationFromKnowledgeBaseResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetKnowledgeBaseURLResponseModel? url = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseURLResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseURLResponseModel)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseFileResponseModel? file = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseFileResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseFileResponseModel)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseTextResponseModel? text = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseTextResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseTextResponseModel)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseFolderResponseModel? folder = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Folder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseFolderResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseFolderResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseFolderResponseModel)}");
                folder = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GetDocumentationFromKnowledgeBaseResponse(
                discriminator?.Type,
                url,

                file,

                text,

                folder
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetDocumentationFromKnowledgeBaseResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseURLResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseURLResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseFileResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseFileResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseTextResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseTextResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsFolder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseFolderResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseFolderResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseFolderResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeInfo);
            }
        }
    }
}