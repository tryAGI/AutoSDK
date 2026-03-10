//HintName: G.Models.AsyncConversationMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for async conversation delivery (Zendesk, Slack, etc.).
    /// </summary>
    public sealed partial class AsyncConversationMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AsyncConversationMetadataDeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeliveryTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_error")]
        public string? DeliveryError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_count")]
        public int? RetryCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_retry_timestamp")]
        public int? LastRetryTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationMetadata" /> class.
        /// </summary>
        /// <param name="deliveryStatus"></param>
        /// <param name="deliveryTimestamp"></param>
        /// <param name="deliveryError"></param>
        /// <param name="externalSystem"></param>
        /// <param name="externalId"></param>
        /// <param name="retryCount">
        /// Default Value: 0
        /// </param>
        /// <param name="lastRetryTimestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncConversationMetadata(
            global::G.AsyncConversationMetadataDeliveryStatus deliveryStatus,
            int deliveryTimestamp,
            string externalSystem,
            string externalId,
            string? deliveryError,
            int? retryCount,
            int? lastRetryTimestamp)
        {
            this.DeliveryStatus = deliveryStatus;
            this.DeliveryTimestamp = deliveryTimestamp;
            this.ExternalSystem = externalSystem ?? throw new global::System.ArgumentNullException(nameof(externalSystem));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.DeliveryError = deliveryError;
            this.RetryCount = retryCount;
            this.LastRetryTimestamp = lastRetryTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationMetadata" /> class.
        /// </summary>
        public AsyncConversationMetadata()
        {
        }
    }
}