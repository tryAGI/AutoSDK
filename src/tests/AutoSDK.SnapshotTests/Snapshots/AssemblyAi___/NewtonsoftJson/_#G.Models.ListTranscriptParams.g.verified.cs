//HintName: G.Models.ListTranscriptParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTranscriptParams
    {
        /// <summary>
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.TranscriptStatus? Status { get; set; }

        /// <summary>
        /// Only get transcripts created on this date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Get transcripts that were created before this transcript ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before_id")]
        public global::System.Guid? BeforeId { get; set; }

        /// <summary>
        /// Get transcripts that were created after this transcript ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_id")]
        public global::System.Guid? AfterId { get; set; }

        /// <summary>
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throttled_only")]
        public bool? ThrottledOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptParams" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10L
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