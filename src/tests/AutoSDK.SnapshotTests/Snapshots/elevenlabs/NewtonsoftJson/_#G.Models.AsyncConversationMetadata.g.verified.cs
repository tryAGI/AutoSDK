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
        [global::Newtonsoft.Json.JsonProperty("delivery_status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter))]
        public global::G.AsyncConversationMetadataDeliveryStatus DeliveryStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delivery_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public int DeliveryTimestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delivery_error")]
        public string? DeliveryError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_system", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalSystem { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalId { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_count")]
        public int? RetryCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_retry_timestamp")]
        public int? LastRetryTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationMetadata" /> class.
        /// </summary>
        /// <param name="deliveryStatus"></param>
        /// <param name="deliveryTimestamp"></param>
        /// <param name="externalSystem"></param>
        /// <param name="externalId"></param>
        /// <param name="deliveryError"></param>
        /// <param name="retryCount">
        /// Default Value: 0
        /// </param>
        /// <param name="lastRetryTimestamp"></param>
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
            this.DeliveryError = deliveryError;
            this.ExternalSystem = externalSystem ?? throw new global::System.ArgumentNullException(nameof(externalSystem));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
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