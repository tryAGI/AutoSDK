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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetKnowledgeBaseSummaryURLResponseModel? url = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryURLResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseSummaryURLResponseModel)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseSummaryFileResponseModel? file = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryFileResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseSummaryFileResponseModel)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseSummaryTextResponseModel? text = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryTextResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseSummaryTextResponseModel)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetKnowledgeBaseSummaryFolderResponseModel? folder = default;
            if (discriminator?.Type == global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Folder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryFolderResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryFolderResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetKnowledgeBaseSummaryFolderResponseModel)}");
                folder = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryURLResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryFileResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryTextResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseSummaryTextResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsFolder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetKnowledgeBaseSummaryFolderResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetKnowledgeBaseSummaryFolderResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetKnowledgeBaseSummaryFolderResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeInfo);
            }
        }
    }
}