//HintName: JsonConverters.ResultItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResultItem>
    {
        /// <inheritdoc />
        public override global::G.ResultItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageTimeBucketResultItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageTimeBucketResultItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageTimeBucketResultItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UsageCompletionsResult? organizationUsageCompletionsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageCompletionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageCompletionsResult)}");
                organizationUsageCompletionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageEmbeddingsResult? organizationUsageEmbeddingsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageEmbeddingsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageEmbeddingsResult)}");
                organizationUsageEmbeddingsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageModerationsResult? organizationUsageModerationsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageModerationsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageModerationsResult)}");
                organizationUsageModerationsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageImagesResult? organizationUsageImagesResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageImagesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageImagesResult)}");
                organizationUsageImagesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageAudioSpeechesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageAudioSpeechesResult)}");
                organizationUsageAudioSpeechesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageAudioTranscriptionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageAudioTranscriptionsResult)}");
                organizationUsageAudioTranscriptionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageVectorStoresResult? organizationUsageVectorStoresResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageVectorStoresResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageVectorStoresResult)}");
                organizationUsageVectorStoresResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageCodeInterpreterSessionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UsageCodeInterpreterSessionsResult)}");
                organizationUsageCodeInterpreterSessionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CostsResult? organizationCostsResult = default;
            if (discriminator?.Object == global::G.UsageTimeBucketResultItemDiscriminatorObject.OrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CostsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CostsResult)}");
                organizationCostsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ResultItem(
                discriminator?.Object,
                organizationUsageCompletionsResult,
                organizationUsageEmbeddingsResult,
                organizationUsageModerationsResult,
                organizationUsageImagesResult,
                organizationUsageAudioSpeechesResult,
                organizationUsageAudioTranscriptionsResult,
                organizationUsageVectorStoresResult,
                organizationUsageCodeInterpreterSessionsResult,
                organizationCostsResult
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResultItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageCompletionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageCompletionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCompletionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageEmbeddingsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageEmbeddingsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageEmbeddingsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageModerationsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageModerationsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageModerationsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageImagesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageImagesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageImagesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageAudioSpeechesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageAudioSpeechesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioSpeechesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageAudioTranscriptionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageAudioTranscriptionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioTranscriptionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageVectorStoresResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageVectorStoresResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageVectorStoresResult, typeInfo);
            }
            else if (value.IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UsageCodeInterpreterSessionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UsageCodeInterpreterSessionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCodeInterpreterSessionsResult, typeInfo);
            }
            else if (value.IsOrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CostsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CostsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationCostsResult, typeInfo);
            }
        }
    }
}