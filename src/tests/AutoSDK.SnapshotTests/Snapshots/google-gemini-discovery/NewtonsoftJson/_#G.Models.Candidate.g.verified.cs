//HintName: G.Models.Candidate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response candidate generated from the model.
    /// </summary>
    public sealed partial class Candidate
    {
        /// <summary>
        /// Output only. Index of the candidate in the list of response candidates.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.Content? Content { get; set; }

        /// <summary>
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating tokens.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishReason")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CandidateFinishReasonJsonConverter))]
        public global::G.CandidateFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Optional. Output only. Details the reason why the model stopped generating tokens. This is populated only when `finish_reason` is set.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishMessage")]
        public string? FinishMessage { get; set; }

        /// <summary>
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safetyRatings")]
        public global::System.Collections.Generic.IList<global::G.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// A collection of source attributions for a piece of content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citationMetadata")]
        public global::G.CitationMetadata? CitationMetadata { get; set; }

        /// <summary>
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Output only. Attribution information for sources that contributed to a grounded answer. This field is populated for `GenerateAnswer` calls.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingAttributions")]
        public global::System.Collections.Generic.IList<global::G.GroundingAttribution>? GroundingAttributions { get; set; }

        /// <summary>
        /// Metadata returned to client when grounding is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingMetadata")]
        public global::G.GroundingMetadata? GroundingMetadata { get; set; }

        /// <summary>
        /// Output only. Average log probability score of the candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avgLogprobs")]
        public double? AvgLogprobs { get; set; }

        /// <summary>
        /// Logprobs Result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobsResult")]
        public global::G.LogprobsResult? LogprobsResult { get; set; }

        /// <summary>
        /// Metadata related to url context retrieval tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlContextMetadata")]
        public global::G.UrlContextMetadata? UrlContextMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        /// <param name="index">
        /// Output only. Index of the candidate in the list of response candidates.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="finishReason">
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating tokens.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="finishMessage">
        /// Optional. Output only. Details the reason why the model stopped generating tokens. This is populated only when `finish_reason` is set.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="safetyRatings">
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </param>
        /// <param name="citationMetadata">
        /// A collection of source attributions for a piece of content.
        /// </param>
        /// <param name="tokenCount">
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="groundingAttributions">
        /// Output only. Attribution information for sources that contributed to a grounded answer. This field is populated for `GenerateAnswer` calls.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="groundingMetadata">
        /// Metadata returned to client when grounding is enabled.
        /// </param>
        /// <param name="avgLogprobs">
        /// Output only. Average log probability score of the candidate.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="logprobsResult">
        /// Logprobs Result
        /// </param>
        /// <param name="urlContextMetadata">
        /// Metadata related to url context retrieval tool.
        /// </param>
        public Candidate(
            int? index,
            global::G.Content? content,
            global::G.CandidateFinishReason? finishReason,
            string? finishMessage,
            global::System.Collections.Generic.IList<global::G.SafetyRating>? safetyRatings,
            global::G.CitationMetadata? citationMetadata,
            int? tokenCount,
            global::System.Collections.Generic.IList<global::G.GroundingAttribution>? groundingAttributions,
            global::G.GroundingMetadata? groundingMetadata,
            double? avgLogprobs,
            global::G.LogprobsResult? logprobsResult,
            global::G.UrlContextMetadata? urlContextMetadata)
        {
            this.Index = index;
            this.Content = content;
            this.FinishReason = finishReason;
            this.FinishMessage = finishMessage;
            this.SafetyRatings = safetyRatings;
            this.CitationMetadata = citationMetadata;
            this.TokenCount = tokenCount;
            this.GroundingAttributions = groundingAttributions;
            this.GroundingMetadata = groundingMetadata;
            this.AvgLogprobs = avgLogprobs;
            this.LogprobsResult = logprobsResult;
            this.UrlContextMetadata = urlContextMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        public Candidate()
        {
        }
    }
}