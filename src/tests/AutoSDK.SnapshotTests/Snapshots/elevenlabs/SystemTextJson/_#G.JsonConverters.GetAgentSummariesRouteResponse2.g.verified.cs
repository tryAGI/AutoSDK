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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetAgentSummariesRouteResponseDiscriminator>(ref readerCopy, options);

            global::G.AgentSummaryBatchSuccessfulResponseModel? success = default;
            if (discriminator?.Status == global::G.GetAgentSummariesRouteResponseDiscriminatorStatus.Success)
            {
                success = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentSummaryBatchSuccessfulResponseModel>(ref reader, options);
            }
            global::G.BatchFailureResponseModel? failure = default;
            if (discriminator?.Status == global::G.GetAgentSummariesRouteResponseDiscriminatorStatus.Failure)
            {
                failure = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BatchFailureResponseModel>(ref reader, options);
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

            if (value.IsSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeof(global::G.AgentSummaryBatchSuccessfulResponseModel), options);
            }
            else if (value.IsFailure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failure, typeof(global::G.BatchFailureResponseModel), options);
            }
        }
    }
}