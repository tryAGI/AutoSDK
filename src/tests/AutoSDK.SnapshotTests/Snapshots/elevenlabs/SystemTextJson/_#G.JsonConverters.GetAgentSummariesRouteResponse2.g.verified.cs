//HintName: G.JsonConverters.GetAgentSummariesRouteResponse2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetAgentSummariesRouteResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetAgentSummariesRouteResponse2>
    {
        /// <inheritdoc />
        public override global::G.GetAgentSummariesRouteResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetAgentSummariesRouteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetAgentSummariesRouteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetAgentSummariesRouteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AgentSummaryBatchSuccessfulResponseModel? success = default;
            if (discriminator?.Status == global::G.GetAgentSummariesRouteResponseDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSummaryBatchSuccessfulResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSummaryBatchSuccessfulResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentSummaryBatchSuccessfulResponseModel)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BatchFailureResponseModel? failure = default;
            if (discriminator?.Status == global::G.GetAgentSummariesRouteResponseDiscriminatorStatus.Failure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BatchFailureResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BatchFailureResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BatchFailureResponseModel)}");
                failure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GetAgentSummariesRouteResponse2(
                discriminator?.Status,
                success,

                failure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetAgentSummariesRouteResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSummaryBatchSuccessfulResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSummaryBatchSuccessfulResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSummaryBatchSuccessfulResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BatchFailureResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BatchFailureResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BatchFailureResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failure!, typeInfo);
            }
        }
    }
}