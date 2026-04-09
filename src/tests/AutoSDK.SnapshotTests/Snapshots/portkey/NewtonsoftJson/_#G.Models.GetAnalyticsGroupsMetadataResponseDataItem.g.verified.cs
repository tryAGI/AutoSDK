//HintName: G.Models.GetAnalyticsGroupsMetadataResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsMetadataResponseDataItem
    {
        /// <summary>
        /// Value of the metadata on which grouping has been done
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_value")]
        public string? MetadataValue { get; set; }

        /// <summary>
        /// Total requests made with this metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Total cost for all requests made with this metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// Average tokens per request for all requests made with this metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_tokens")]
        public int? AvgTokens { get; set; }

        /// <summary>
        /// Average weighted feedback for all requests made with this metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_weighted_feedback")]
        public int? AvgWeightedFeedback { get; set; }

        /// <summary>
        /// Total requests with feedback
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests_with_feedback")]
        public int? RequestsWithFeedback { get; set; }

        /// <summary>
        /// The last seen timestamp for this metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_seen")]
        public global::System.DateTime? LastSeen { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsMetadataResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMetadataResponseDataItem" /> class.
        /// </summary>
        /// <param name="metadataValue">
        /// Value of the metadata on which grouping has been done
        /// </param>
        /// <param name="requests">
        /// Total requests made with this metadata
        /// </param>
        /// <param name="cost">
        /// Total cost for all requests made with this metadata
        /// </param>
        /// <param name="avgTokens">
        /// Average tokens per request for all requests made with this metadata
        /// </param>
        /// <param name="avgWeightedFeedback">
        /// Average weighted feedback for all requests made with this metadata
        /// </param>
        /// <param name="requestsWithFeedback">
        /// Total requests with feedback
        /// </param>
        /// <param name="lastSeen">
        /// The last seen timestamp for this metadata
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
        public GetAnalyticsGroupsMetadataResponseDataItem(
            string? metadataValue,
            int? requests,
            int? cost,
            int? avgTokens,
            int? avgWeightedFeedback,
            int? requestsWithFeedback,
            global::System.DateTime? lastSeen,
            global::G.GetAnalyticsGroupsMetadataResponseDataItemObject? @object)
        {
            this.MetadataValue = metadataValue;
            this.Requests = requests;
            this.Cost = cost;
            this.AvgTokens = avgTokens;
            this.AvgWeightedFeedback = avgWeightedFeedback;
            this.RequestsWithFeedback = requestsWithFeedback;
            this.LastSeen = lastSeen;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMetadataResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsMetadataResponseDataItem()
        {
        }
    }
}