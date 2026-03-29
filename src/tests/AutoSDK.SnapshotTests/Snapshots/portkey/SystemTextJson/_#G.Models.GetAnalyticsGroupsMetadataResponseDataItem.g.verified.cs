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
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_value")]
        public string? MetadataValue { get; set; }

        /// <summary>
        /// Total requests made with this metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Total cost for all requests made with this metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// Average tokens per request for all requests made with this metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_tokens")]
        public int? AvgTokens { get; set; }

        /// <summary>
        /// Average weighted feedback for all requests made with this metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_weighted_feedback")]
        public int? AvgWeightedFeedback { get; set; }

        /// <summary>
        /// Total requests with feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_with_feedback")]
        public int? RequestsWithFeedback { get; set; }

        /// <summary>
        /// The last seen timestamp for this metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public global::System.DateTime? LastSeen { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter))]
        public global::G.GetAnalyticsGroupsMetadataResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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