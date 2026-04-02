//HintName: G.JsonConverters.Data.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Data>
    {
        /// <inheritdoc />
        public override global::G.Data Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator>(ref readerCopy, options);

            global::G.GetKnowledgeBaseSummaryURLResponseModel? url = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseSummaryURLResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseSummaryFileResponseModel? file = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseSummaryFileResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseSummaryTextResponseModel? text = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseSummaryTextResponseModel>(ref reader, options);
            }
            global::G.GetKnowledgeBaseSummaryFolderResponseModel? folder = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Folder)
            {
                folder = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseSummaryFolderResponseModel>(ref reader, options);
            }

            var __value = new global::G.Data(
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
            global::G.Data value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.GetKnowledgeBaseSummaryTextResponseModel), options);
            }
            else if (value.IsFolder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeof(global::G.GetKnowledgeBaseSummaryFolderResponseModel), options);
            }
        }
    }
}