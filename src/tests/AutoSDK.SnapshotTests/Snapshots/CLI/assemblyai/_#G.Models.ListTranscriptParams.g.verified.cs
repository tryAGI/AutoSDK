//HintName: G.Models.ListTranscriptParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
    /// </summary>
    public sealed partial class ListTranscriptParams
    {
        /// <summary>
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptStatusJsonConverter))]
        public global::G.TranscriptStatus? Status { get; set; }

        /// <summary>
        /// Only get transcripts created on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Get transcripts that were created before this transcript ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_id")]
        public global::System.Guid? BeforeId { get; set; }

        /// <summary>
        /// Get transcripts that were created after this transcript ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_id")]
        public global::System.Guid? AfterId { get; set; }

        /// <summary>
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled_only")]
        public bool? ThrottledOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptParams" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn">
        /// Only get transcripts created on this date
        /// </param>
        /// <param name="beforeId">
        /// Get transcripts that were created before this transcript ID
        /// </param>
        /// <param name="afterId">
        /// Get transcripts that were created after this transcript ID
        /// </param>
        /// <param name="throttledOnly">
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTranscriptParams(
            long? limit,
            global::G.TranscriptStatus? status,
            global::System.DateTime? createdOn,
            global::System.Guid? beforeId,
            global::System.Guid? afterId,
            bool? throttledOnly)
        {
            this.Limit = limit;
            this.Status = status;
            this.CreatedOn = createdOn;
            this.BeforeId = beforeId;
            this.AfterId = afterId;
            this.ThrottledOnly = throttledOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptParams" /> class.
        /// </summary>
        public ListTranscriptParams()
        {
        }
    }
}