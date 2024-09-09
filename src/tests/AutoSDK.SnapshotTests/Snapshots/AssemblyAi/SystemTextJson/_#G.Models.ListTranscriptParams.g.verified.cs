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
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long Limit { get; set; } = 10L;

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.TranscriptStatusJsonConverter))]
        public global::G.TranscriptStatus? Status { get; set; }

        /// <summary>
        /// Only get transcripts created on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public global::System.DateTime CreatedOn { get; set; }

        /// <summary>
        /// Get transcripts that were created before this transcript ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_id")]
        public string? BeforeId { get; set; }

        /// <summary>
        /// Get transcripts that were created after this transcript ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_id")]
        public string? AfterId { get; set; }

        /// <summary>
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled_only")]
        public bool ThrottledOnly { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}