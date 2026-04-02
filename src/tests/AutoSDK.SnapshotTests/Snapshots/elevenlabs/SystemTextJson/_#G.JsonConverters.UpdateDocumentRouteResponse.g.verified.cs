//HintName: G.JsonConverters.UpdateDocumentRouteResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UpdateDocumentRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateDocumentRouteResponse>
    {
        /// <inheritdoc />
        public override global::G.UpdateDocumentRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateDocumentRouteResponseDiscriminator>(ref readerCopy, options);

            global::G.GetKnowledgeBaseURLResponseModel? url = default;
            if (discriminator?.Type == global::G.UpdateDocumentRouteResponseDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseURLResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseFileResponseModel? file = default;
            if (discriminator?.Type == global::G.UpdateDocumentRouteResponseDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseFileResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseTextResponseModel? text = default;
            if (discriminator?.Type == global::G.UpdateDocumentRouteResponseDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseTextResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseFolderResponseModel? folder = default;
            if (discriminator?.Type == global::G.UpdateDocumentRouteResponseDiscriminatorType.Folder)
            {
                folder = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseFolderResponseModel>(ref reader, options);
            }

            var __value = new global::G.UpdateDocumentRouteResponse(
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
            global::G.UpdateDocumentRouteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.GetKnowledgeBaseURLResponseModel), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::G.GetKnowledgeBaseFileResponseModel), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.GetKnowledgeBaseTextResponseModel), options);
            }
            else if (value.IsFolder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeof(global::G.GetKnowledgeBaseFolderResponseModel), options);
            }
        }
    }
}