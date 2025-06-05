//HintName: G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse>
    {
        /// <inheritdoc />
        public override global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetKnowledgeBaseURLResponseModel? url = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseURLResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseURLResponseModel)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseFileResponseModel? file = default;
            if (discriminator?.Type == global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseFileResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseFileResponseModel)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(
                discriminator?.Type,
                url,
                file
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse value,
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
        }
    }
}